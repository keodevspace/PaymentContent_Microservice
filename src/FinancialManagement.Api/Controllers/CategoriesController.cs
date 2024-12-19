using FinancialManagement.Api.Models;
using FinancialManagement.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace FinancialManagement.Api.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
        {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
            {
            _categoryService = categoryService;
            }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
            {
            var categories = await _categoryService.GetAllCategoriesAsync();
            return Ok(categories);
            }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category category)
            {
            await _categoryService.CreateCategoryAsync(category);
            return CreatedAtAction(nameof(GetCategories), new { id = category.Id }, category);
            }
        }
    }
