using Microsoft.AspNetCore.Mvc;

namespace exception_handling.Controllers
{
    [Route("Error")]
    public class ErrorController : Controller
    {
        private readonly ILogger _logger;

        [Route("{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the resource you requested could not be found.";
                    break;

                default:
                    ViewBag.ErrorMessage = "Something went wrong. Please try again later.";
                    break;
            }

            return View("Error");
        }

        public IActionResult Index()
        {
            try
            {
                // Code that may throw exceptions
                throw new Exception("Simulated error.");
            }
            catch(Exception ex)
            {
                // Log the exception
                _logger.LogError($"Error occurred: {ex.Message}");

                // Handle the exception
                ViewBag.ErrorMessage = "An error occurred while processing your request.";
                return View("Error");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                // Simulate fetching data
                if (id == 0)
                {
                    return NotFound("Item not found.");     // Return 404 Not Found
                }

                // Process data and return response
                return Ok("Data retrieved successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occurred: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error."); // Return 500 Internal Server Error
            }
        }
    }
}
