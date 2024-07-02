using Microsoft.AspNetCore.Mvc;

namespace dependency_injection.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IMyService _myService;
        //public HomeController(IMyService myService)
        //{
            //_myService = myService;
        //}

        public IActionResult Index()
        {
            // Use _myService
            return View();
        }
    }
}
