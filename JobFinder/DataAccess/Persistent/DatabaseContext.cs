using AutoMapper;
using JobFinder.Core.Entity;
using JobFinder.DataAccess.Seed;
using JobFinder.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;

namespace JobFinder.DataAccess.Persistent
{
    public class DatabaseContext: DbContext
    {
        private IMapper _mapper;
        public DatabaseContext(DbContextOptions<DatabaseContext> options, IMapper mapper) : base(options)
        {
            _mapper = mapper;
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<Metadata> Metadatas { get; set; }


        public override int SaveChanges()
        {
            base.SaveChangesAsync();
            AddTimestamps();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddTimestamps();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries<IAuditableEntity>()
                .Where(x => x.Entity is IAuditableEntity &&
                            (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow; // current datetime

                if (entity.State == EntityState.Added)
                {
                    (entity.Entity).CreatedAt = now;
                }

                (entity.Entity).UpdatedAt = now;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var metadatas = DataSeed.GetMetadataSeeds();
            var companies = DataSeed.GetCompanySeeds();
            var users = DataSeed.GetUserSeeds();
            IEnumerable<Job> jobs = _mapper.Map<List<Job>>(DataSeed.GetJobSeeds());
            foreach (var job in jobs)
            {
                job.ProvinceId = companies.FirstOrDefault(x => x.Id == job.CompanyId).ProvinceId;
            }
            modelBuilder.Entity<Account>().UseTpcMappingStrategy();
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<User>().Property(u => u.Skills).HasConversion<string>();
            modelBuilder.Entity<User>().Property(u => u.Certifications).HasConversion<string>(
                    c => JsonConvert.SerializeObject(c, Formatting.Indented,
                        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                    c => JsonConvert.DeserializeObject<IEnumerable<Certification>>(c,
                        new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }))
                .Metadata
                .SetValueComparer(new ValueComparer<IEnumerable<Certification>>(
                    (c1, c2) => c1.SequenceEqual(c2), 
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())), // Hash code computation
                    c => c.ToList()));
            modelBuilder.Entity<Metadata>().HasData(metadatas);
            modelBuilder.Entity<Company>().HasData(companies);
            modelBuilder.Entity<Job>().HasData(jobs);
        }
    }
}