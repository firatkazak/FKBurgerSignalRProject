using FKBurger.Business.Abstract;
using FKBurger.DTO.AboutDTO;
using FKBurger.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AboutController : ControllerBase
{
	private readonly IAboutService _aboutService;//Servisten 1 örnek alıp CRUD metotlarını Controller'da yazıyoruz.

	public AboutController(IAboutService aboutService)//Önce Constructor'da bunu geçiyoruz.
	{
		_aboutService = aboutService;
	}

	[HttpGet]
	public IActionResult AboutList()
	{
		var values = _aboutService.TGetListAll();//Listenin tümünü getir, values değişkenine ata.
		return Ok(values);//values'u dön.
	}

	[HttpPost]
	public IActionResult CreateAbout(CreateAboutDTO createAboutDTO)
	{
		About about = new About()
		{
			Title = createAboutDTO.Title,
			Description = createAboutDTO.Description,
			ImageUrl = createAboutDTO.ImageUrl,
		};
		//1 tane About nesnesi yarattık. Bunu CreateAboutDTO örneğimiz ile map'leyip about değişkenine attık.
		_aboutService.TAdd(about);//about'u ekle dedik.
		return Ok("Hakkımda kısmı başarılı bir şekilde eklendi.");//Kullanıcıya mesaj verdik.
	}

	[HttpDelete("{id}")]
	public IActionResult DeleteAbout(int id)
	{
		var value = _aboutService.TGetById(id);//Id'ye göre getirdik getirdiğimiz değeri value değişkenine attık.
		_aboutService.TDelete(value);//getirilen değeri sildik.
		return Ok("Hakkımda alanı silindi.");//Kullanıcıya mesaj verdik.
	}

	[HttpPut]
	public IActionResult UpdateAbout(UpdateAboutDTO updateAboutDTO)
	{
		About about = new About()
		{
			AboutID = updateAboutDTO.AboutID,
			Title = updateAboutDTO.Title,
			Description = updateAboutDTO.Description,
			ImageUrl = updateAboutDTO.ImageUrl,
		};
		//1 tane About nesnesi yarattık. Bunu UpdateAboutDTO örneğimiz ile map'leyip about değişkenine attık.
		_aboutService.TUpdate(about);//about'u güncelle dedik.
		return Ok("Hakkımda alanı güncellendi.");//Kullanıcıya mesaj verdik.
	}

	[HttpGet("{id}")]
    public IActionResult GetAbout(int id)
	{
		var value = _aboutService.TGetById(id);//Id'ye göre getirdik getirdiğimiz değeri value değişkenine attık.
		return Ok(value);//value'yu döndük.
	}

}