using AutoMapper;
using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DTO.ProductDTO;
using FKBurger.Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FKBurger.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;

    public ProductController(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult ProductList()
    {
        var value = _mapper.Map<List<ResultProductDTO>>(_productService.TGetListAll());
        return Ok(value);
    }

    [HttpGet("ProductCount")]
    public IActionResult ProductCount()
    {
        return Ok(_productService.TProductCount());
    }

    [HttpGet("ProductAvgPriceByHamburger")]
    public IActionResult ProductAvgPriceByHamburger()
    {
        return Ok(_productService.TProductAvgPriceByHamburger());
    }

    [HttpGet("ProductNameByMaxPrice")]
    public IActionResult ProductNameByMaxPrice()
    {
        return Ok(_productService.TProductNameByMaxPrice());
    }

    [HttpGet("ProductNameByMinPrice")]
    public IActionResult ProductNameByMinPrice()
    {
        return Ok(_productService.TProductNameByMinPrice());
    }

    [HttpGet("ProductPriceAvg")]
    public IActionResult ProductPriceAvg()
    {
        return Ok(_productService.TProductPriceAvg());
    }

    [HttpGet("ProductCountByCategoryNameHamburger")]
    public IActionResult ProductCountByCategoryNameHamburger()
    {
        return Ok(_productService.TProductCountByCategoryNameHamburger());
    }

    [HttpGet("ProductCountByCategoryNameDrink")]
    public IActionResult ProductCountByCategoryNameDrink()
    {
        return Ok(_productService.TProductCountByCategoryNameDrink());
    }

    [HttpGet("ProductListWithCategory")]
    public IActionResult ProductListWithCategory()
    {
        var context = new FKBurgerDBContext();
        var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategoryDTO
        {
            CategoryName = y.Category.CategoryName,
            Description = y.Description,
            ImageUrl = y.ImageUrl,
            Price = y.Price,
            ProductID = y.ProductID,
            ProductName = y.ProductName,
            ProductStatus = y.ProductStatus
        });
        return Ok(values.ToList());
    }

    [HttpPost]
    public IActionResult CreateProduct(CreateProductDTO createProductDTO)
    {
        _productService.TAdd(new Product()
        {
            CategoryID = createProductDTO.CategoryID,
            Description = createProductDTO.Description,
            ImageUrl = createProductDTO.ImageUrl,
            Price = createProductDTO.Price,
            ProductName = createProductDTO.ProductName,
            ProductStatus = createProductDTO.ProductStatus
        });
        return Ok("Ürün Bilgisi Eklendi");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var value = _productService.TGetById(id);
        _productService.TDelete(value);
        return Ok("Ürün Bilgisi Silindi.");
    }

    [HttpGet("{id}")]
    public IActionResult GetProduct(int id)
    {
        var value = _productService.TGetById(id);
        return Ok(value);
    }

    [HttpPut]
    public IActionResult UpdateProduct(UpdateProductDTO updateProductDTO)
    {
        _productService.TUpdate(new Product()
        {
            CategoryID = updateProductDTO.CategoryID,
            Description = updateProductDTO.Description,
            ImageUrl = updateProductDTO.ImageUrl,
            Price = updateProductDTO.Price,
            ProductID = updateProductDTO.ProductID,
            ProductName = updateProductDTO.ProductName,
            ProductStatus = updateProductDTO.ProductStatus
        });
        return Ok("Ürün Bilgisi Güncellendi.");
    }

}
