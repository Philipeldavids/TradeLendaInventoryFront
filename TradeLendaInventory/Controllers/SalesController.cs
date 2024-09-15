using Microsoft.AspNetCore.Mvc;

namespace TradeLendaInventory.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetSales()
        {
            return View();
        }

        public IActionResult POS()
        {
            return View();
        }

        public IActionResult GetSalesInvoice()
        {
            return View();

        }

        public async Task<IActionResult> GetSalesReturn()
        {
            return View();
        }
    }
}
