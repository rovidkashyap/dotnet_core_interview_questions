using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace caching_in_aspnet_core.Controllers
{
    public class HomeController : Controller
    {
        // Use In-Memory Cache in Contoller

        private readonly IMemoryCache _memoryCache;
        public HomeController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public IActionResult Index()
        {
            string cacheKey = "currentTime";
            if(!_memoryCache.TryGetValue(cacheKey, out string currentTime))
            {
                currentTime = DateTime.Now.ToString();
                var cacheEntryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5),
                    SlidingExpiration = TimeSpan.FromMinutes(1)
                };
                _memoryCache.Set(cacheKey, currentTime, cacheEntryOptions);
            }

            ViewBag.CurrentTime = currentTime;
            return View();
        }
    }
}
