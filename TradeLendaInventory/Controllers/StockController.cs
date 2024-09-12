using Microsoft.AspNetCore.Mvc;

namespace TradeLendaInventory.Controllers
{
    public class StockController : Controller
    {
        public IActionResult GetStock()
        {
            return View();
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
