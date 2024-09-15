using Microsoft.AspNetCore.Mvc;

namespace TradeLendaInventory.Controllers
{
    public class SalesReportController : Controller
    {
        public IActionResult GetSalesReport()
        {
            return View();
        }
    }
}
