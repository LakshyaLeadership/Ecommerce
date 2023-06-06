using Lakshya.Ecommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lakshya.Ecommerce.Api.Controllers
{
    [ApiController]
    [Route("api/sales")]
    public class SalesController : ControllerBase
    {
        private readonly ISalesService _salesService;

        public SalesController(ISalesService salesService)
        {
            _salesService = salesService;
        }

        [HttpGet("reports")]
        public async Task<IActionResult> GenerateSalesReport(DateTime startDate, DateTime endDate)
        {
            var reportData = await _salesService.GetSalesData(startDate, endDate).ConfigureAwait(false);
            var reportFilePath = _salesService.GenerateReport(reportData);

            var fileBytes = System.IO.File.ReadAllBytes(reportFilePath);
            return File(fileBytes, "application/pdf", Path.GetFileName(reportFilePath));
        }
    }

}
