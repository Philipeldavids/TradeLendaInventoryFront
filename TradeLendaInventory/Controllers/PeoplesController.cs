using Microsoft.AspNetCore.Mvc;
using TradeLendaInventory.Models;
using TradeLendaInventory.Models.ViewModel;
using TradeLendaInventory.Utility;

namespace TradeLendaInventory.Controllers
{
    public class PeoplesController : Controller
    {
        private readonly HttpClient _httpClient;

        public PeoplesController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("MyClient");
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomer()
        {
            var result = await _httpClient.GetAsync(Constants.ClientRoutes.CustomerList);
            if (result.IsSuccessStatusCode)
            {
                var res = await result.Content.ReadFromJsonAsync<ServiceResponse<List<Customer>>>();
                if (res != null)
                {
                    CustomerViewModel customerView = new CustomerViewModel()
                    {
                        Customers = res.Data
                    };
                    return View(customerView);
                }
            
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddCustomer([FromForm]CustomerModel customer)
        {
            var result = await _httpClient.PostAsJsonAsync(Constants.ClientRoutes.CustomerAdd, customer);
            if(result.IsSuccessStatusCode)
            {
                return RedirectToAction("GetCustomer", "Peoples");
            }
            return RedirectToAction("GetCustomer", "Peoples");
        }

        public IActionResult GetSupplier()
        {
            return View();
        }
        public IActionResult GetStore()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetWarehouse()
        {
            var result = await _httpClient.GetAsync(Constants.ClientRoutes.WarehouseADD);
            if (result.IsSuccessStatusCode)
            {
                var res = await result.Content.ReadFromJsonAsync<ServiceResponse<List<Warehouse>>>();
                WarehouseViewModel viewModel = new WarehouseViewModel()
                {
                    Warehouses = res.Data
                };
                return View(viewModel);
            }

            return View();
        }

        [HttpPost]

        public async Task<ActionResult> AddWarehouse(WarehouseModel model)
        {
            var result = await _httpClient.PostAsJsonAsync(Constants.ClientRoutes.WarehouseAdd, model);
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("GetWarehouse", "Peoples");
            }
            return RedirectToAction("GetWarehouse", "Peoples");
        }

    }
}
