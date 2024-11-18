using JobFinder.Core.Entity;
using JobFinder.DataAccess.Seed;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess.Persistent
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
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
                .Where(x => x.Entity is IAuditableEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

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
            var position = DataSeed.GetJobSeeds(companies, metadatas);
            modelBuilder.Entity<Account>().UseTpcMappingStrategy();
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<User>().Property(u=>u.Skills).HasConversion<string>();
            modelBuilder.Entity<Metadata>().HasData(metadatas);
            modelBuilder.Entity<Company>().HasData(companies);
            modelBuilder.Entity<Job>().HasData(position);
        }
    }
}
