using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
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
        public async Task<ActionResult> AddCustomer(Customer customer)
        {

            var result = await _httpClient.PostAsJsonAsync(Constants.ClientRoutes.CustomerAdd, customer);
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("GetCustomer", "Peoples");
            }
            return RedirectToAction("GetCustomer", "Peoples");

        }

        [HttpGet]
        public async Task<ActionResult> DeleteCustomer(string Id)
        {
            var result = await _httpClient.DeleteAsync(Constants.ClientRoutes.DeleteCustomer + Id.ToString());
            if (result.IsSuccessStatusCode)
            {
                var res = await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
                if (res.Data == true)
                {
                    return RedirectToAction("GetCustomer", "Peoples");
                } 
               
            }
            return RedirectToAction("GetCustomer", "Peoples");
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

        public async Task<ActionResult> AddWarehouse(Warehouse model)
        {
            var result = await _httpClient.PostAsJsonAsync(Constants.ClientRoutes.WarehouseAdd, model);
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("GetWarehouse", "Peoples");
            }
            return RedirectToAction("GetWarehouse", "Peoples");
        }

        [HttpGet]
        public async Task<IActionResult> GetSupplier()
        {
            var result = await _httpClient.GetAsync(Constants.ClientRoutes.SupplierList);
            if (result.IsSuccessStatusCode)
            {
                var res = await result.Content.ReadFromJsonAsync<ServiceResponse<List<Supplier>>>();

                SupplierViewModel viewModel = new SupplierViewModel()
                {
                    Suppliers = res.Data
                };
                return View(viewModel);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSupplier(Supplier supplier)
        {
            var result = await _httpClient.PostAsJsonAsync(Constants.ClientRoutes.SupplierADD, supplier);

            if (result.IsSuccessStatusCode)
            {

                return RedirectToAction("GetSupplier", "Peoples");

            }
            return RedirectToAction("GetSupplier", "Peoples");
        }
        [HttpGet]
        public async Task<IActionResult> GetStore()
        {
            var resut = await _httpClient.GetAsync(Constants.ClientRoutes.StoreList);
            {
                if (resut.IsSuccessStatusCode)
                {
                    var res = await resut.Content.ReadFromJsonAsync<ServiceResponse<List<Store>>>();
                    StoreViewModel viewModel = new StoreViewModel()
                    {
                        Stores = res.Data
                    };
                    return View(viewModel);
                }
                return View();
            }
        }

        public async Task<IActionResult> AddStore(Store store)
        {
            var result = await _httpClient.PostAsJsonAsync(Constants.ClientRoutes.StoreADD, store);

            if(result.IsSuccessStatusCode)
            {
                return RedirectToAction("GetStore", "Peoples");
            }
            return RedirectToAction("GetStore", "Peoples");
        }

    }
}

