using AutoMapper;
using FKBurger.Business.Abstract;
using FKBurger.DTO.CategoryDTO;
using FKBurger.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    private readonly IMapper _mapper;

    public CategoryController(ICategoryService categoryService, IMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult CategoryList()
    {
        var value = _mapper.Map<List<ResultCategoryDTO>>(_categoryService.TGetListAll());
        return Ok(value);
    }

    [HttpGet("CategoryCount")]
    public IActionResult CategoryCount()
    {
        return Ok(_categoryService.TCategoryCount());
    }

    [HttpGet("ActiveCategoryCount")]
    public IActionResult ActiveCategoryCount()
    {
        return Ok(_categoryService.TActiveCategoryCount());
    }

    [HttpGet("PassiveCategoryCount")]
    public IActionResult PassiveCategoryCount()
    {
        return Ok(_categoryService.TPassiveCategoryCount());
    }

    [HttpPost]
    public IActionResult CreateCategory(CreateCategoryDTO createCategoryDTO)
    {
        _categoryService.TAdd(new Category()
        {
            CategoryName = createCategoryDTO.CategoryName,
            CategoryStatus = true,
        });
        return Ok("Kategori Eklendi");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCategory(int id)
    {
        var value = _categoryService.TGetById(id);
        _categoryService.TDelete(value);
        return Ok("Kategori Silindi.");
    }

    [HttpGet("{id}")]
    public IActionResult GetCategory(int id)
    {
        var value = _categoryService.TGetById(id);
        return Ok(value);
    }

    [HttpPut]
    public IActionResult UpdateCategory(UpdateCategoryDTO updateCategoryDTO)
    {
        _categoryService.TUpdate(new Category()
        {
            CategoryID = updateCategoryDTO.CategoryID,
            CategoryName = updateCategoryDTO.CategoryName,
            CategoryStatus = updateCategoryDTO.CategoryStatus,
        });
        return Ok("Kategori Güncellendi.");
    }

}