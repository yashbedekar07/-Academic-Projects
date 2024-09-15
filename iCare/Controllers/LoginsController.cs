using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using iCare.Models;

namespace iCare.Controllers
{
    public class LoginsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Login
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewsModel model)
        {
            // Validate the username and password here
            if (model.Username == "Sahil" && model.Password == "Sahil@5787")
            {
                // Authentication successful
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.Username)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true, // Make the cookie persistent
                    ExpiresUtc = DateTimeOffset.UtcNow.AddYears(1) // Set cookie expiration to one year
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }

        public async Task<IActionResult> Logout()
        {
            // Clear any authentication tokens, session variables, etc.
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            // Redirect the user to the login page or any other appropriate page
            return RedirectToAction("Index", "Logins");
        }
    }
}
