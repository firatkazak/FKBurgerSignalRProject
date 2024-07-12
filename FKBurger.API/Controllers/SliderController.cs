using AutoMapper;
using FKBurger.Business.Abstract;
using FKBurger.DTO.SliderDTO;
using FKBurger.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SliderController : ControllerBase
{
    private readonly ISliderService _sliderService;
    private readonly IMapper _mapper;
    public SliderController(ISliderService sliderService, IMapper mapper)
    {
        _sliderService = sliderService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult SliderList()
    {
        var value = _mapper.Map<List<ResultSliderDTO>>(_sliderService.TGetListAll());
        return Ok(value);
    }
    [HttpPost]
    public IActionResult CreateSlider(CreateSliderDTO createSliderDTO)
    {
        _sliderService.TAdd(new Slider()
        {
            Description1 = createSliderDTO.Description1,
            Description2 = createSliderDTO.Description2,
            Description3 = createSliderDTO.Description3,
            Title1 = createSliderDTO.Title1,
            Title2 = createSliderDTO.Title2,
            Title3 = createSliderDTO.Title3
        });
        return Ok("Öne Çıkan Bilgisi Eklendi");
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteSlider(int id)
    {
        var value = _sliderService.TGetById(id);
        _sliderService.TDelete(value);
        return Ok("Öne Çıkan Bilgisi Silindi");
    }
    [HttpGet("{id}")]
    public IActionResult GetSlider(int id)
    {
        var value = _sliderService.TGetById(id);
        return Ok(value);
    }
    [HttpPut]
    public IActionResult UpdateSlider(UpdateSliderDTO updateSliderDTO)
    {
        _sliderService.TUpdate(new Slider()
        {
            Description1 = updateSliderDTO.Description1,
            Description2 = updateSliderDTO.Description2,
            Description3 = updateSliderDTO.Description3,
            Title1 = updateSliderDTO.Title1,
            Title2 = updateSliderDTO.Title2,
            Title3 = updateSliderDTO.Title3,
            SliderID = updateSliderDTO.SliderID
        });
        return Ok("Öne Çıkan Alan Bilgisi Güncellendi");
    }
}