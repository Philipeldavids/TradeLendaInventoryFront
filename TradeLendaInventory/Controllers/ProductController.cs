using Microsoft.AspNetCore.Mvc;

namespace TradeLendaInventory.Controllers
{
    public class ProductController : Controller
    {
        public ProductController()
        {
            
        }
        public IActionResult GetProductList()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        public IActionResult GetExpiredProduct()
        {
            return View();
        }

        public IActionResult GetLowStockProducts()
        {
            return View();
        }
        public IActionResult GetCategory() 
        {
            return View();
        }
    }
}
