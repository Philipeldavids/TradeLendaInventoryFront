using Microsoft.AspNetCore.Mvc;
using TradeLendaInventory.Models;
using TradeLendaInventory.Models.ViewModel;
using TradeLendaInventory.Utility;

namespace TradeLendaInventory.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly HttpClient _httpClient;

        public PurchaseController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("MyClient");
        }
        [HttpGet]
        public async Task<IActionResult> GetPurchase()
        {
            var result = await _httpClient.GetAsync(Constants.ClientRoutes.PurchaseGET);
            if (result.IsSuccessStatusCode)
            {
                var res = await result.Content.ReadFromJsonAsync<List<Purchase>>();
                PurchaseVIewModel model = new PurchaseVIewModel()
                {
                    Purchases = res
                };

                return View(model);
            }
            
            return View();
        }

        public IActionResult GetPurchaseOrderReport()
        {
            return View();
        }

        public IActionResult GetPurchaseReturn()
        {
            return View();
        }
    }
}
