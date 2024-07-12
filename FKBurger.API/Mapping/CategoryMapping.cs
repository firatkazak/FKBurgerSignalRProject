using AutoMapper;
using FKBurger.DTO.CategoryDTO;
using FKBurger.Entity.Entities;

namespace FKBurger.API.Mapping;
public class CategoryMapping : Profile
{
	public CategoryMapping()
	{
		CreateMap<Category, CreateCategoryDTO>().ReverseMap();
		CreateMap<Category, GetCategoryDTO>().ReverseMap();
		CreateMap<Category, ResultCategoryDTO>().ReverseMap();
		CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
	}
}

