using Microsoft.AspNetCore.Mvc;

namespace session_and_state_management.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("SessionKey", "SessionValue");
            var value = HttpContext.Session.GetString("SessionKey");

            #region Cookies

            // Setting a cookie
            Response.Cookies.Append("CookieKey", "CookieValue");

            // Getting a Cookie
            var cookieValue = Request.Cookies["CookieKey"];

            #endregion

            #region Query Strings

            // Setting a query string parameter in a URL
            return RedirectToAction("ActionName", new { param1 = "value1" });

            // Getting query string parameter
            var param1 = Request.Query["param1"];

            #endregion

            #region TempData

            // Setting TempData
            TempData["Message"] = "This is a temporary message.";

            // Getting TempData
            var message = TempData["Message"] as string;

            #endregion

            return View();
        }
    }
}
