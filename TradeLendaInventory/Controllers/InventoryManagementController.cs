﻿using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using System.Collections;
using System.Drawing.Printing;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Reflection.Metadata;
using TradeLendaInventory.Models;
using TradeLendaInventory.Models.ViewModel;
using TradeLendaInventory.Utility;

namespace TradeLendaInventory.Controllers
{
    public class InventoryManagementController : Controller
    {
        private readonly HttpClient _httpClient;
        

        public InventoryManagementController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("MyClient");
        }

        [HttpGet]
        public async Task<ActionResult> GetProductList(int pagesize, int pagenumber)
        {
            var token = HttpContext.Session.GetString("JWTToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result = await _httpClient.GetAsync(Constants.ClientRoutes.Productlist + "?pageSize=" + pagesize +"&pageNumber=" + pagenumber);
            if (result.IsSuccessStatusCode){
                       
                var res = await result.Content.ReadFromJsonAsync<ServiceResponse<PaginationModel<IEnumerable<Product>>>>();
                ProductViewModel model = new ProductViewModel();

                model.Products = res.Data.PageItems;
                return View(model);
            }

            return View();
        }

        public ActionResult AddProduct(Product product)
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> DeleteProduct(string Id)
        {
            var token = HttpContext.Session.GetString("JWTToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result = await _httpClient.DeleteAsync(Constants.ClientRoutes.DeleteProduct + Id.ToString());
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("GetProductList", "InventoryManagement");
            }
            return RedirectToAction("GetProductList", "InventoryManagement");
        }
        [HttpGet]
        public async Task<ActionResult> GetExpiredProduct()
        {
            var token = HttpContext.Session.GetString("JWTToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

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
        }

        [HttpGet]
        public async Task<ActionResult> GetLowStockProducts()
        {
         
            return View();
        }

        [HttpPost]
        public async Task<PartialViewResult> GetSlide(int tabNumber)
        {
            var token = HttpContext.Session.GetString("JWTToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            if (tabNumber == 1)
            {
                var products = await _httpClient.GetAsync(Constants.ClientRoutes.LowStockProductList);
                if (products.IsSuccessStatusCode)
                {
                    var res = products.Content.ReadFromJsonAsync<List<Product>>();
                    ProductViewModel model = new ProductViewModel
                    {
                        Products = res.Result
                    };
                    return PartialView("_SlidePartial", model);
                }
                return PartialView("_SlidePartial");
            }
            

            var produts = await _httpClient.GetAsync(Constants.ClientRoutes.NoStockProductList);
            if (produts.IsSuccessStatusCode)
            {
                var res = produts.Content.ReadFromJsonAsync<List<Product>>();
                ProductViewModel model = new ProductViewModel
                {
                    Products = res.Result
                };
                return PartialView("_SlidePartial", model);
            }
            return PartialView("_SlidePartial");
        }
        [HttpGet]
        public async Task<ActionResult> GetCategory() 
        {
            var token = HttpContext.Session.GetString("JWTToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result = await _httpClient.GetAsync(Constants.ClientRoutes.CategoryList);
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadFromJsonAsync<List<Category>>();
                CategoryViewModel model = new CategoryViewModel
                {
                    Categories = res.Result
                };
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddCategory(Category category)
        {
            var token = HttpContext.Session.GetString("JWTToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result = await _httpClient.PostAsJsonAsync(Constants.ClientRoutes.CategoryADD, category);
            if(result.IsSuccessStatusCode)  
            {
                return RedirectToAction("GetCategory", "InventoryManagement");
            }
            return RedirectToAction("GetCategory", "InventoryManagement");
        }
        

        public async Task<JsonResult> GetCategoryById(string id)
        {
            var token = HttpContext.Session.GetString("JWTToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result = await _httpClient.GetAsync(Constants.ClientRoutes.CategoryById + id.ToString());
            if (result.IsSuccessStatusCode)
            {
                //var res = await result.Content.ReadFromJsonAsync<Category>();
                return Json(new
                {
                    data = result.Content
                });               
            }
            return Json("");
        }
        [HttpPut]
        public async Task<IActionResult> SaveEdit(Category category)
        {
            var token = HttpContext.Session.GetString("JWTToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); 

            var result = await _httpClient.PutAsJsonAsync<Category>(Constants.ClientRoutes.EditCategory, category);
            if (result.IsSuccessStatusCode)
            {
                var res = await result.Content.ReadAsStringAsync();
                if(res == "true")   
                {
                    return RedirectToAction("GetCategory", "InventoryManagement");
                }
            }
            return RedirectToAction("GetCategory", "InventoryManagement");
        }
        
        [HttpGet]

        public async Task<IActionResult> DeleteCategory(string id)
        {
            var token = HttpContext.Session.GetString("JWTToken");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var result =await _httpClient.DeleteAsync(Constants.ClientRoutes.DeleteCategory + id.ToString());
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("GetCategory", "InventoryManagement");
            }
            return RedirectToAction("GetCategory", "InventoryManagement");
        }
        public IActionResult CreateBarcode() 
        { 
            return View();
        }

        public IActionResult GetBrand() 
        {
            return View();
        }
    }
}