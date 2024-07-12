using AutoMapper;
using FKBurger.DTO.DiscountDTO;
using FKBurger.Entity.Entities;

namespace FKBurger.API.Mapping;
public class DiscountMapping : Profile
{
	public DiscountMapping()
	{
		CreateMap<Discount, CreateDiscountDTO>().ReverseMap();
		CreateMap<Discount, GetDiscountDTO>().ReverseMap();
		CreateMap<Discount, ResultDiscountDTO>().ReverseMap();
		CreateMap<Discount, UpdateDiscountDTO>().ReverseMap();
	}
}
