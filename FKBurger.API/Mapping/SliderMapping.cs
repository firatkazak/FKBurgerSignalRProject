using AutoMapper;
using FKBurger.DTO.SliderDTO;
using FKBurger.Entity.Entities;

namespace FKBurger.API.Mapping;
public class SliderMapping : Profile
{
    public SliderMapping()
    {
        CreateMap<Slider, ResultSliderDTO>().ReverseMap();
    }
}