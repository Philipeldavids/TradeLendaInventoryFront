using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http;
using TradeLendaInventory.Models;
using TradeLendaInventory.Models.ViewModel;
using TradeLendaInventory.Utility;

namespace TradeLendaInventory.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClient)
        {
            _logger = logger;
            _httpClient = httpClient.CreateClient("MyClient");   
        }

        public async Task<IActionResult> Index()
        {
            var products = await _httpClient.GetAsync(Constants.ClientRoutes.ExpiredProductList);
            if (products.IsSuccessStatusCode)
            {
                var result = products.Content.ReadFromJsonAsync<List<Product>>();
                ProductViewModel model = new ProductViewModel
                {
                    Products = result.Result
                };
                return View(model);
            }
            return View();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
