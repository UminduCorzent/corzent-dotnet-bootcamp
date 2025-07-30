using Microsoft.AspNetCore.Mvc;

namespace DotNetLearner.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = new[]
            {
                new { Id = 1, Name = "Laptop" },
                new { Id = 2, Name = "Phone" }
            };
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = new { Id = id, Name = $"Product {id}" };
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create(int id, string name)
        {
            var product = new { Id = id, Name = name};
            return CreatedAtAction(nameof(GetById), new { id }, product);
        }
    }
}
