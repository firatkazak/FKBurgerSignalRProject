using AutoMapper;
using FKBurger.DTO.ProductDTO;
using FKBurger.Entity.Entities;

namespace FKBurger.API.Mapping;
public class ProductMapping : Profile
{
	public ProductMapping()
	{
		CreateMap<Product, CreateProductDTO>().ReverseMap();
		CreateMap<Product, GetProductDTO>().ReverseMap();
		CreateMap<Product, ResultProductDTO>().ReverseMap();
		CreateMap<Product, UpdateProductDTO>().ReverseMap();
		CreateMap<Product, ResultProductWithCategoryDTO>().ReverseMap();
	}
}
