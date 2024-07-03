using Microsoft.AspNetCore.Mvc;

namespace routing_in_aspnet_core.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            // Action code to return all products
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Action code to return a product by id
            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            // Action Code to create a new Product
            return Ok();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
