using Microsoft.AspNetCore.Mvc;
using TradeLendaInventory.Models;
using TradeLendaInventory.Models.ViewModel;
using TradeLendaInventory.Utility;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TradeLendaInventory.Controllers
{
    public class StockController : Controller
    {
        private readonly HttpClient _httpClient;

        public StockController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("MyClient");
        }

        [HttpGet]
        public async Task<IActionResult> GetStock()
        {
            var result = await _httpClient.GetAsync(Constants.ClientRoutes.StockList);

            if(result.IsSuccessStatusCode)
            {
                var res = await result.Content.ReadFromJsonAsync<List<Stock>>();
                StockViewModel viewModel = new StockViewModel()
                {
                    stocks = res
                };

                return View(viewModel);
            }
            return View();
        }
        public async Task<JsonResult> GetProduct()
        {
            var product = await _httpClient.GetAsync(Constants.ClientRoutes.Productlist);
            List<string> data = new();
            if(product.IsSuccessStatusCode)
            {
                var result = await product.Content.ReadFromJsonAsync<List<Product>>(); 
                if(result!= null)
                {
                    data = result.Select(x=>x.ProductName).ToList();
                   
                }
            }
            return Json(new { data = data });
        }
        [HttpPost]
        public async Task<IActionResult> AddStock(Stock stock)
        {
            var result = await _httpClient.PostAsJsonAsync(Constants.ClientRoutes.StockAdd, stock);

            if(result.IsSuccessStatusCode)
            {
                return RedirectToAction("GetStock", "Stock");
            }

            return RedirectToAction("GetStock", "Stock");
        }
        public IActionResult StockADjustment()
        {
            return View();
        }

        public IActionResult StockTransfer()
        {
            return View();
        }
    }
}
