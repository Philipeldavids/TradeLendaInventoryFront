using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using TradeLendaInventory.Models;
using TradeLendaInventory.Models.ViewModel;
using TradeLendaInventory.Utility;

namespace TradeLendaInventory.Controllers
{
    public class AuthController : Controller
    {
        private readonly HttpClient _httpClient;
        public AuthController(IHttpClientFactory httpClient)
        {

            _httpClient = httpClient.CreateClient("MyClient"); ;

        }
        [HttpGet]
        public IActionResult SignIn()
        {

            return View();            
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(Constants.ClientRoutes.Token, model);

           
            if (response.IsSuccessStatusCode)
            {
                var tokenResponse = await response.Content.ReadAsStringAsync();
                var serialize = JsonConvert.DeserializeObject<TokenResponse>(tokenResponse);
                var token = serialize.Token;
                var refreshToken = serialize.RefreshToken;
                var roles = serialize.User.Role.ToString();

               
               ViewBag.Username = serialize.User.UserName;
                ViewBag.Role = serialize.User.Role.ToString();
               ViewBag.IsActive= serialize.User.IsActive;



                                // Store token in session or a cookie
                HttpContext.Session.SetString("JWTToken", token);
                HttpContext.Session.SetString("Username", serialize.User.UserName);
                HttpContext.Session.SetString("Role", serialize.User.Role.ToString());
                HttpContext.Session.SetString("IsActive", Convert.ToString(serialize.User.IsActive));
                HttpContext.Session.SetString("RefreshToken", refreshToken);

                if (roles == "Admin")
                {

                    return RedirectToAction("Index", "Home");
                }
                else if (roles == "ShopOwner")
                {
                    return RedirectToAction("Index", "Sales");
                }
                else if (roles == "Customer")
                {
                    return RedirectToAction("POS", "Sales");
                }

            }

            ModelState.AddModelError("", "Invalid login attempt.");
            return View(model);
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("JWTToken");
            return RedirectToAction("SignIn", "Auth");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
           
                HttpResponseMessage response = await _httpClient.PostAsJsonAsync(Constants.ClientRoutes.Register, model);
                if (!response.IsSuccessStatusCode)
                {
                    return View(model);
                }
                return RedirectToAction("SignIn", "Auth");
 
           
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult ResetPasswordFromMail()
        {
            return View();
        }

        public IActionResult ResetPassword()
        {
            return RedirectToAction("SignIn", "Auth");
        }
    }
}