using Lakshya.Ecommerce.Services.Models;

namespace Lakshya.Ecommerce.Services
{
    public interface ISalesService
    {
        Task<List<SaleModel>> ShowReport(DateTime startDate, DateTime endDate);
        string ExportAsPdf(List<SaleModel> salesData);
    }

}