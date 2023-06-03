using Lakshya.Ecommerce.Services.Models;
using Lakshya.Ecommerce.Repositories;
using Lakshya.Ecommerce.Repositories.Entities;
using AutoMapper;

namespace Lakshya.Ecommerce.Services
{

    public class SalesService : ISalesService
    {
        private readonly ISalesRepository _salesRepository;
        private readonly IMapper mapper;

        public SalesService(ISalesRepository salesRepository, IMapper mapper)
        {
            _salesRepository = salesRepository;
            this.mapper = mapper;
        }

        public async Task<List<SaleModel>> GetSalesData(DateTime startDate, DateTime endDate)
        {
            return mapper.Map<List<SaleModel>>(await _salesRepository.GetSalesData(startDate, endDate).ConfigureAwait(false));
        }

        public string GenerateReport(List<SaleModel> salesData)
        {
            //var report = new FastReport.Report();
            //report.Load("path/to/sales_report_template.frx");

            //report.RegisterData(salesData, "SalesData");
            //report.Prepare();

            //var exportOptions = new FastReport.Export.Pdf.PDFExport();
            var reportFilePath = "path/to/generated_report.pdf";
            //report.Export(exportOptions, reportFilePath);

            return reportFilePath;
        }
    }

}