using Microsoft.AspNetCore.Mvc;

namespace cross_site_request_forgery.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string username, string password)
        {
            // Login logic
            return View();
        }
    }
}
