using Microsoft.EntityFrameworkCore;
using WPFTest.Domain.Models;

namespace WPFTest.EntityFramework
{
    public class DataContext :DbContext
    {

        public DbSet<User> UserTable { get; set; }
        public DbSet<Account> AccountTable { get; set; }
        public DbSet<AssetTransaction> AssetTransactionTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetTransaction>().OwnsOne(a => a.Stock); 
            //meken kivva explicitly stock meka athule tiyenna one kiyala.
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=WPFTestDB;Trusted_Connection=True;MultipleActiveResultSets=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
