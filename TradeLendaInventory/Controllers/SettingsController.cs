using Microsoft.AspNetCore.Mvc;

namespace TradeLendaInventory.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }

    }
}
