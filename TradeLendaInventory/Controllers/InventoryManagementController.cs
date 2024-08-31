using Microsoft.AspNetCore.Mvc;

namespace TradeLendaInventory.Controllers
{
    public class InventoryManagementController : Controller
    {
        public InventoryManagementController()
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

        public IActionResult CreateBarcode() 
        { 
            return View();
        }
    }
}
