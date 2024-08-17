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
    }
}
