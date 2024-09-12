using Microsoft.AspNetCore.Mvc;

namespace TradeLendaInventory.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult GetPurchase()
        {
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
