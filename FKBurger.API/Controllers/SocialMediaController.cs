using AutoMapper;
using FKBurger.Business.Abstract;
using FKBurger.DTO.SocialMediaDTO;
using FKBurger.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SocialMediaController : ControllerBase
{
	private readonly ISocialMediaService _socialMediaService;
	private readonly IMapper _mapper;

	public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
	{
		_socialMediaService = socialMediaService;
		_mapper = mapper;
	}

	[HttpGet]
	public IActionResult SocialMediatList()
	{
		var value = _mapper.Map<List<ResultSocialMediaDTO>>(_socialMediaService.TGetListAll());
		return Ok(value);
	}

	[HttpPost]
	public IActionResult CreateSocialMedia(CreateSocialMediaDTO createSocialMediaDTO)
	{
		_socialMediaService.TAdd(new SocialMedia()
		{
			Icon = createSocialMediaDTO.Icon,
			Title = createSocialMediaDTO.Title,
			Url = createSocialMediaDTO.Url,
		});
		return Ok("Ürün Bilgisi Eklendi");
	}

	[HttpDelete("{id}")]
	public IActionResult DeleteSocialMedia(int id)
	{
		var value = _socialMediaService.TGetById(id);
		_socialMediaService.TDelete(value);
		return Ok("Ürün Bilgisi Silindi.");
	}

	[HttpGet("{id}")]
    public IActionResult GetSocialMedia(int id)
	{
		var value = _socialMediaService.TGetById(id);
		return Ok(value);
	}

	[HttpPut]
	public IActionResult UpdateSocialMedia(UpdateSocialMediaDTO updateSocialMediaDTO)
	{
		_socialMediaService.TUpdate(new SocialMedia()
		{
			Icon = updateSocialMediaDTO.Icon,
			Title = updateSocialMediaDTO.Title,
			SocialMediaID = updateSocialMediaDTO.SocialMediaID,
			Url = updateSocialMediaDTO.Url,
		});
		return Ok("Ürün Bilgisi Güncellendi.");
	}

}
