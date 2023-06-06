using Lakshya.Ecommerce.Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lakshya.Ecommerce.Repositories
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {
        }
        public DbSet<Sale> Sales { get; set; }

        public void SeedData()
        {
          if (!Sales.Any())
          {
            var sales = new List<Sale>
            {
                new Sale { ProductName = "Apple MacBook Pro", Quantity = 5, Amount = 1000, Date = DateTime.Now },
                new Sale { ProductName = "Dell XPS 13", Quantity = 10, Amount = 1200, Date = DateTime.Now },
                new Sale { ProductName = "HP Spectre x360", Quantity = 2, Amount = 1300, Date = DateTime.Now },
                new Sale { ProductName = "Lenovo ThinkPad X1 Carbon", Quantity = 8, Amount = 1500, Date = DateTime.Now },
                new Sale { ProductName = "Asus ROG Zephyrus G14", Quantity = 3, Amount = 1800, Date = DateTime.Now },
                new Sale { ProductName = "Acer Swift 5", Quantity = 6, Amount = 900, Date = DateTime.Now },
                new Sale { ProductName = "Microsoft Surface Laptop 4", Quantity = 12, Amount = 1400, Date = DateTime.Now },
                new Sale { ProductName = "MSI GS66 Stealth", Quantity = 4, Amount = 2000, Date = DateTime.Now },
                new Sale { ProductName = "Toshiba Portégé X30L-G", Quantity = 7, Amount = 1100, Date = DateTime.Now },
                new Sale { ProductName = "Sony Vaio S13", Quantity = 9, Amount = 1300, Date = DateTime.Now }
            };

            Sales.AddRange(sales);
            SaveChanges();
          }
        }
  }

}
