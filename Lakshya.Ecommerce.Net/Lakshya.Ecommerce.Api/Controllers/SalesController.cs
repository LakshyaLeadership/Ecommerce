using Lakshya.Ecommerce.Services;
using Lakshya.Ecommerce.Services.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Lakshya.Ecommerce.Api.Controllers
{
  [ApiController]
  [Route("api/sales")]
  //[EnableCors("AbhiAllowsAllDuringDevelopment")]
  public class SalesController : ControllerBase
  {
    private readonly ISalesService _salesService;

    public SalesController(ISalesService salesService)
    {
      _salesService = salesService;
    }

    [HttpGet("ExportAsPdf")]
    public async Task<IActionResult> ExportAsPdf(DateTime startDate, DateTime endDate)
    {
      var reportData = await _salesService.ShowReport(startDate, endDate).ConfigureAwait(false);

      var reportFilePath = _salesService.ExportAsPdf(reportData);

      var fileBytes = System.IO.File.ReadAllBytes(reportFilePath);
      return File(fileBytes, "application/pdf", Path.GetFileName(reportFilePath));
    }

    [HttpGet("ShowReport")]
    [Produces(typeof(List<SaleModel>))]
    public async Task<IActionResult> ShowReport(DateTime startDate, DateTime endDate)
    {
      return Ok(await _salesService.ShowReport(startDate, endDate).ConfigureAwait(false));
    }
  }

}
