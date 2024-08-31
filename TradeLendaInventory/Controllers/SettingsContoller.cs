using Microsoft.AspNetCore.Mvc;

namespace TradeLendaInventory.Controllers
{
    public class SettingsContoller : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
