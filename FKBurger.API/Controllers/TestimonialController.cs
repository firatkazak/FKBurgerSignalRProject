using AutoMapper;
using FKBurger.Business.Abstract;
using FKBurger.DTO.TestimonialDTO;
using FKBurger.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestimonialController : ControllerBase
{
	private readonly ITestimonialService _testimonialService;
	private readonly IMapper _mapper;

	public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
	{
		_testimonialService = testimonialService;
		_mapper = mapper;
	}

	[HttpGet]
	public IActionResult TestimonialtList()
	{
		var value = _mapper.Map<List<ResultTestimonialDTO>>(_testimonialService.TGetListAll());
		return Ok(value);
	}

	[HttpPost]
	public IActionResult CreateTestimonial(CreateTestimonialDTO createTestimonialDTO)
	{
		_testimonialService.TAdd(new Testimonial()
		{
			Comment = createTestimonialDTO.Comment,
			ImageUrl = createTestimonialDTO.ImageUrl,
			Name = createTestimonialDTO.Name,
			Status = createTestimonialDTO.Status,
			Title = createTestimonialDTO.Title,
		});
		return Ok("Müşteri Yorum Bilgisi Eklendi");
	}

	[HttpDelete("{id}")]
	public IActionResult DeleteTestimonial(int id)
	{
		var value = _testimonialService.TGetById(id);
		_testimonialService.TDelete(value);
		return Ok("Müşteri Yorum Bilgisi Silindi");
	}

	[HttpGet("{id}")]
    public IActionResult GetTestimonial(int id)
	{
		var value = _testimonialService.TGetById(id);
		return Ok(value);
	}

	[HttpPut]
	public IActionResult UpdateTestimonial(UpdateTestimonialDTO updateTestimonialDTO)
	{
		_testimonialService.TUpdate(new Testimonial()
		{
			Comment = updateTestimonialDTO.Comment,
			ImageUrl = updateTestimonialDTO.ImageUrl,
			Name = updateTestimonialDTO.Name,
			Status = updateTestimonialDTO.Status,
			TestimonialID = updateTestimonialDTO.TestimonialID,
			Title = updateTestimonialDTO.Title,
		});
		return Ok("Müşteri Yorum Bilgisi Güncellendi");
	}

}