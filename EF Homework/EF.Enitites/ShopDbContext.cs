using Microsoft.EntityFrameworkCore;

namespace EF.Enitites
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-65I7PJ4;Database=ShopDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
