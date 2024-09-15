using Microsoft.AspNetCore.Mvc;
using TradeLendaInventory.Models;
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
            var result = await _httpClient.GetAsync(Constants.ClientRoutes.PurchaseADD);
            if (result.IsSuccessStatusCode)
            {
                var res = await result.Content.ReadFromJsonAsync<List<Purchase>>();
                
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
