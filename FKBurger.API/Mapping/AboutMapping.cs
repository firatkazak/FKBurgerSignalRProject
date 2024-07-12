using AutoMapper;
using FKBurger.DTO.AboutDTO;
using FKBurger.Entity.Entities;

namespace FKBurger.API.Mapping;
public class AboutMapping : Profile
{
	public AboutMapping()
	{
		CreateMap<About, CreateAboutDTO>().ReverseMap();
		CreateMap<About, GetAboutDTO>().ReverseMap();
		CreateMap<About, ResultAboutDTO>().ReverseMap();
		CreateMap<About, UpdateAboutDTO>().ReverseMap();
	}
}
