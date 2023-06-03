using Lakshya.Ecommerce.Services.Models;

namespace Lakshya.Ecommerce.Services
{
    public interface ISalesService
    {
        Task<List<SaleModel>> GetSalesData(DateTime startDate, DateTime endDate);
        string GenerateReport(List<SaleModel> salesData);
    }

}