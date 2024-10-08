using Azure.Storage.Blobs.Models;
using JobFinder.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess.Persistent
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<PositionApplication> PositionApplications { get; set; }
        
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
            var entities = ChangeTracker.Entries<ICredentialEntity>()
                .Where(x => x.Entity is ICredentialEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

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

            modelBuilder.Entity<Account>().HasData(new Account
            {
                Id = Guid.NewGuid(),
                Username = "Admin",
                Password = "Admin",
                Email = "admin@gmail.com",
                Phone = "0123456789"
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
