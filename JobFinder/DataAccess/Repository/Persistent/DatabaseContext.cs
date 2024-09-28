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
    }
}
