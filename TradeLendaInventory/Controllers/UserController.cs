using Microsoft.AspNetCore.Mvc;

namespace TradeLendaInventory.Controllers
{
    public class UserController : Controller
    {
        public IActionResult AddRoles()
        {
            return View();
        }

        public IActionResult AddProfile()
        {
            return RedirectToAction("GetUserProfiles", "User");
        }
        public IActionResult GetUserProfile()
        {
            return View();
        }

        public IActionResult EditUser()
        {
            return View();
        }

        public IActionResult DeleteUser()
        {
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> GetUser()
        {
            return View();
        }
        
    }
}
