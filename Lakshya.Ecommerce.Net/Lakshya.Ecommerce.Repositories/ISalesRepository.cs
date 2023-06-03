using Lakshya.Ecommerce.Repositories.Entities;

namespace Lakshya.Ecommerce.Repositories
{
    public interface ISalesRepository
    {
        Task<List<Sale>> GetSalesData(DateTime startDate, DateTime endDate);
    }
}