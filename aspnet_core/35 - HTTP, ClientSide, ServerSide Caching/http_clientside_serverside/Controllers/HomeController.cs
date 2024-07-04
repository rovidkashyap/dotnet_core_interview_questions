using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace http_clientside_serverside.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;
        public HomeController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        // HTTP Cache Example
        [HttpGet]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Client, NoStore = false)]
        public IActionResult Get()
        {
            var data = new { Value = "This is Cached Data" };
            return Ok(data);
        }

        // Client-Side Cache Example
        [HttpGet]
        public IActionResult GetClientCache()
        {
            var data = new { Value = "This is cached data" };
            var lastModified = new DateTime(2024, 1, 1);

            if (Request.Headers.ContainsKey("If-None-Match"))
            {
                var etag = Request.Headers["If-None-Match"].ToString();
                if (etag == "12345") // Example ETag
                {
                    return StatusCode(304); // Not Modified
                }
            }

            Response.Headers["ETag"] = "12345"; // Example ETag
            Response.Headers["Last-Modified"] = lastModified.ToString("R");
            Response.Headers["Cache-Control"] = "public,max-age=60";
            return Ok(data);
        }

        // Server-Side Cache Example
        [HttpGet]
        public IActionResult GetServerCache()
        {
            var cacheKey = "myData";
            if (!_memoryCache.TryGetValue(cacheKey, out string cachedData))
            {
                // Simulate fetching data from a database
                cachedData = "This is cached data";
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromSeconds(60));

                _memoryCache.Set(cacheKey, cachedData, cacheEntryOptions);
            }

            return Ok(cachedData);
        }
    }
}
