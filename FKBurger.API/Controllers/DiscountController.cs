using AutoMapper;
using FKBurger.Business.Abstract;
using FKBurger.DTO.DiscountDTO;
using FKBurger.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DiscountController : ControllerBase
{
    private readonly IDiscountService _discountService;
    private readonly IMapper _mapper;
    public DiscountController(IDiscountService discountService, IMapper mapper)
    {
        _discountService = discountService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult DiscountList()
    {
        var value = _mapper.Map<List<ResultDiscountDTO>>(_discountService.TGetListAll());
        return Ok(value);
    }
    [HttpPost]
    public IActionResult CreateDiscount(CreateDiscountDTO createDiscountDTO)
    {
        _discountService.TAdd(new Discount()
        {
            Amount = createDiscountDTO.Amount,
            Description = createDiscountDTO.Description,
            ImageUrl = createDiscountDTO.ImageUrl,
            Title = createDiscountDTO.Title,
            Status = false
        });
        return Ok("İndirim Bilgisi Eklendi");
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteDiscount(int id)
    {
        var value = _discountService.TGetById(id);
        _discountService.TDelete(value);
        return Ok("İndirim Bilgisi Silindi");
    }
    [HttpGet("{id}")]
    public IActionResult GetDiscount(int id)
    {
        var value = _discountService.TGetById(id);
        return Ok(value);
    }
    [HttpPut]
    public IActionResult UpdateDiscount(UpdateDiscountDTO updateDiscountDTO)
    {
        _discountService.TUpdate(new Discount()
        {
            Amount = updateDiscountDTO.Amount,
            Description = updateDiscountDTO.Description,
            ImageUrl = updateDiscountDTO.ImageUrl,
            Title = updateDiscountDTO.Title,
            DiscountID = updateDiscountDTO.DiscountID,
            Status = false
        });
        return Ok("İndirim Bilgisi Güncellendi");
    }
    [HttpGet("ChangeStatusToTrue/{id}")]
    public IActionResult ChangeStatusToTrue(int id)
    {
        _discountService.TChangeStatusToTrue(id);
        return Ok("Ürün İndirimi Aktif Hale Getirildi");
    }

    [HttpGet("ChangeStatusToFalse/{id}")]
    public IActionResult ChangeStatusToFalse(int id)
    {
        _discountService.TChangeStatusToFalse(id);
        return Ok("Ürün İndirimi Pasif Hale Getirildi");
    }

    [HttpGet("GetListByStatusTrue")]
    public IActionResult GetListByStatusTrue()
    {
        return Ok(_discountService.TGetListByStatusTrue());
    }
}