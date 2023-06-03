using Lakshya.Ecommerce.Repositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lakshya.Ecommerce.Repositories
{
    public class SalesRepository : ISalesRepository
    {
        private readonly EcommerceDbContext _dbContext;

        public SalesRepository(EcommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Sale>> GetSalesData(DateTime startDate, DateTime endDate)
        {
            return await _dbContext.Sales
                .Where(s => s.Date >= startDate && s.Date <= endDate)
                .ToListAsync().ConfigureAwait(false);
        }
    }
}