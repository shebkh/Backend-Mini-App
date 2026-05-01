using Backend_Mini_App.Interface;
using Backend_Mini_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Mini_App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductApiController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public ProductApiController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("Backend API works");
        }

        [HttpPost("Create-Product")]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            var result = await _categoryService.CreateProductAsync(product);
            return Ok(result);
        }

        [HttpPost("Update-Product")]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            var result = await _categoryService.UpdateProductAsync(product);
            return Ok(result);
        }

        [HttpDelete("Delete-Product/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await _categoryService.DeleteProductAsync(id);
            return Ok(result);
        }

        [HttpGet("Get-AllProducts")]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _categoryService.GetProductsAsync();
            return Ok(result);
        }

        [HttpGet("Get-ProductById/{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var result = await _categoryService.GetProductByIdAsync(id);
            return Ok(result);
        }

        [HttpGet("Search-Product")]
        public async Task<IActionResult> SearchProductByName([FromQuery] string name)
        {
            var result = await _categoryService.SearchProductAsync(name);
            return Ok(result);
        }
    }
}