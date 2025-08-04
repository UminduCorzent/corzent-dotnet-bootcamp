using DotNetLearner.API.DTOs;
using DotNetLearner.API.Models;
using DotNetLearner.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNetLearner.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);
            if (product == null) return BadRequest(new { message = "Product not found" });

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create(ProductDto dto)
        {
            var product = _productService.Create(dto);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ProductDto dto)
        {
            var isUpdated = _productService.Update(id, dto);
            if (!isUpdated)
                return BadRequest(new { message = "Product not found" });

            return Ok(new { message = "Product updated successfully" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var isDeleted = _productService.Delete(id);
            if (!isDeleted)
                return BadRequest(new { message = "Product not found" });

            return Ok(new { message = "Product deleted successfully" });
        }
    }
}
