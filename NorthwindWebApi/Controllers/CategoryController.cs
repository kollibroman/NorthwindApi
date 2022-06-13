using Microsoft.AspNetCore.Mvc;
using NorthwindApp.Interfaces;
using NorthwindApp.Models.CreateNewDto;

namespace NorthwindWebApi.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var categories = _service.GetCategoryDtos();
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public IActionResult GetId([FromRoute]long id)
        {
            var category = _service.GetCategoryDto(id);
            return Ok(category);
        }
        [HttpPost]
        public IActionResult CreateCategory([FromBody] CreateCategoryDto dto)
        {
            var category = _service.AddCategory(dto);
            return Created($"/api/category/{category.CategoryId}", category);
        }
    }
}