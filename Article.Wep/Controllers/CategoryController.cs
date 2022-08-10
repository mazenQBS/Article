using Article.Application.Service;
using Article.Application.Validator;
using Article.Data.Repository;
using Article.Domain.Dto;
using Article.Domain.Entity;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;


namespace Article.Wep.Controllers

{

    [ApiController]
    [Route("api/[Controller]/[action]")]
    public class CategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryRepository categoryRepository,IMapper mapper)
        {
            _mapper = mapper;
            _categoryService = new CategoryService(categoryRepository);
        }


        [HttpPost]
        public IActionResult Create(CategoryDto categoryDto)
        {
            if (!IsValid(categoryDto)) return BadRequest();
            var category = _mapper.Map<Category>(categoryDto);
            _categoryService.Create(category);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var category = _categoryService.GetById(id);
            
            if (category == null) return NotFound();
            
            _categoryService.Delete(id);
            return Ok();
        }


        [HttpPatch]
        public IActionResult Update(CategoryDto categoryDto)
        {
            if (!IsValid(categoryDto)) return BadRequest();
            var category = _mapper.Map<Category>(categoryDto);
            _categoryService.Update(category);
            return NoContent();
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var category = _categoryService.GetById(id);
            if (category==null) return NotFound();
            
            return Ok(category);
        }

        private static bool IsValid(CategoryDto category)
            =>new CategoryDtoValidator().Validate(category).IsValid;
    }
}




