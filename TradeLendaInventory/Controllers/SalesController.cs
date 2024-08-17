using Microsoft.AspNetCore.Mvc;

namespace TradeLendaInventory.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
