using Lakshya.Ecommerce.Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lakshya.Ecommerce.Repositories
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options)
        {
        }
        public DbSet<Sale> Sales { get; set; }
    }

}