using AutoMapper;
using FKBurger.DTO.SocialMediaDTO;
using FKBurger.Entity.Entities;

namespace FKBurger.API.Mapping;
public class SocialMediaMapping : Profile
{
	public SocialMediaMapping()
	{
		CreateMap<SocialMedia, CreateSocialMediaDTO>().ReverseMap();
		CreateMap<SocialMedia, GetSocialMediaDTO>().ReverseMap();
		CreateMap<SocialMedia, ResultSocialMediaDTO>().ReverseMap();
		CreateMap<SocialMedia, UpdateSocialMediaDTO>().ReverseMap();
	}
}
