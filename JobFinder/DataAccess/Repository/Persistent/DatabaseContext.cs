using JobFinder.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess.Repository.Persistent
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<User> Users { get; set; }

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
