using Microsoft.AspNetCore.Mvc;
using TradeLendaInventory.Models;
using TradeLendaInventory.Models.ViewModel;
using TradeLendaInventory.Utility;


namespace TradeLendaInventory.Controllers
{
    public class UserController : Controller
    {
        private readonly HttpClient _httpClient;

        public UserController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("MyClient");
        }

        public IActionResult AddRoles()
        {
            return View();
        }

        public IActionResult AddProfile()
        {
            return RedirectToAction("GetUserProfiles", "User");
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(CreateUserRequestDTO userrequest)
        {
            var result = await _httpClient.PostAsJsonAsync(Constants.ClientRoutes.AddUser, userrequest);
            if (result.IsSuccessStatusCode)
            {               
                return RedirectToAction("GetUser", "User");
            }
            return RedirectToAction("GetUser", "User");
        }
        public IActionResult GetUserProfile()
        {
            return View();
        }

        public IActionResult EditUser()
        {
            return View();
        }

        [HttpGet]
        public async  Task<IActionResult> DeleteUser(string Id)
        {
            var reslt = await _httpClient.DeleteAsync(Constants.ClientRoutes.DeleteUser + Id.ToString());

            if (reslt.IsSuccessStatusCode)
            {
                return RedirectToAction("GetUser", "User");
            }
            return RedirectToAction("GetUser", "User");
        }
        [HttpGet]
        public async Task<ActionResult> GetUser()
        {
            var result = await _httpClient.GetAsync(Constants.ClientRoutes.GetUser);
            if (result.IsSuccessStatusCode)
            {
                var res = await result.Content.ReadFromJsonAsync<List<User>>();
                UserViewModel viewModel = new UserViewModel()
                {
                    users = res
                };
                return View(viewModel);
            }
            return View();
        }
        
    }
}
