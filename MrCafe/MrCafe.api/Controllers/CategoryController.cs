using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MrCafe.Core.Data;
using MrCafe.Core.Service;
using System.Collections.Generic;

namespace MrCafe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetAllCategories")]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        public List<Category> GetAllCategories()
        {
            return _categoryService.GetAllCategories();
        }

        [HttpPost("CreateCategory")]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        public bool CreateCategory([FromBody] Category category)
        {
            return _categoryService.CreateCategory(category);
        }


        [HttpDelete("DeleteCategory/{id}")]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        public bool DeleteCategory(int id)
        {
            return _categoryService.DeleteCategory(id);
        }


        [HttpPut("UpdateCategory")]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        public bool UpdateCategory([FromBody] Category category)
        {
            return _categoryService.UpdateCategory(category);
        }

        [HttpPost("GetCategoryById")]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        public List<Category> GetCategoryById([FromBody] Category category)
        {
            return _categoryService.GetCategoryById(category);
        }

    }
}
