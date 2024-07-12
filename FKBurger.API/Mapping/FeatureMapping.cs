using AutoMapper;
using FKBurger.DTO.FeatureDTO;
using FKBurger.Entity.Entities;

namespace FKBurger.API.Mapping;
public class FeatureMapping : Profile
{
	public FeatureMapping()
	{
		CreateMap<Feature, CreateFeatureDTO>().ReverseMap();
		CreateMap<Feature, GetFeatureDTO>().ReverseMap();
		CreateMap<Feature, ResultFeatureDTO>().ReverseMap();
		CreateMap<Feature, UpdateFeatureDTO>().ReverseMap();
	}
}
