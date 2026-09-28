using Microsoft.AspNetCore.Mvc;
using ProductManagement.Models.DTOs;
using ProductManagement.Services.Interfaces;

namespace ProductManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        // GET: api/products
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _service.GetAllProducts();

            return Ok(products);
        }

        // GET: api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _service.GetProductById(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        // POST: api/products
        [HttpPost]
        public async Task<IActionResult> AddProduct(
            CreateProductDto dto)
        {
            var product = await _service.AddProduct(dto);

            return CreatedAtAction(
                nameof(GetProductById),
                new { id = product.ProductId },
                product);
        }

        // PUT: api/products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(
            int id, UpdateProductDto dto)
        {
            var result = await _service.UpdateProduct(id, dto);

            if (!result)
                return NotFound();

            return NoContent();
        }

        // DELETE: api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await _service.DeleteProduct(id);

            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}