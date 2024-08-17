using Microsoft.AspNetCore.Mvc;

namespace TradeLendaInventory.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
