using DotNetLearner.API.DTOs;
using DotNetLearner.API.Models;
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
            List<Product> products =
            [
                new() { Id = 1, Name = "Laptop", Price = 380_000 },
                new() { Id = 2, Name = "Phone", Price = 50_000 }
            ];
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = new Product { Id = id, Name = $"Product {id}", Price = 3000 };
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProductDto dto)
        {
            var product = new Product
            {
                Id = 10,
                Name = dto.Name,
                Price = dto.Price,
            };
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }
    }
}
