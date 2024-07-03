using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace prevent_xss_attack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    public class UserInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string UserName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
