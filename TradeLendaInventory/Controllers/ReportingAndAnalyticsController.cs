using Microsoft.AspNetCore.Mvc;
using TradeLendaInventory.Models;
using TradeLendaInventory.Models.ViewModel;
using TradeLendaInventory.Utility;

namespace TradeLendaInventory.Controllers
{
    public class ReportingAndAnalyticsController : Controller
    {
        private readonly HttpClient _httpClient;

        public ReportingAndAnalyticsController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("MyClient");
        }

        [HttpGet]
        public async Task<IActionResult> GetSalesReport()
        {
            var result = await _httpClient.GetAsync(Constants.ClientRoutes.GetSalesReport);
            if (result.IsSuccessStatusCode)
            {
                var res = await result.Content.ReadFromJsonAsync<List<SalesReport>>();
                SalesReportViewModel model = new SalesReportViewModel()
                {
                    SalesReports = res
                };

                return View(model);
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetPurchaseReport()
        {
            var result = await _httpClient.GetAsync(Constants.ClientRoutes.GetPurchaseReport);

            if (result.IsSuccessStatusCode)
            {
                var res = await result.Content.ReadFromJsonAsync<List<PurchaseReport>>();
                PurchaseReportViewModel model = new PurchaseReportViewModel()
                {
                    PurchaseReports = res
                };
                return View(model);
            }
            return View();
        }
    }
}
