using AutoMapper;
using FKBurger.DTO.TestimonialDTO;
using FKBurger.Entity.Entities;

namespace FKBurger.API.Mapping;
public class TestimonialMapping : Profile
{
	public TestimonialMapping()
	{
		CreateMap<Testimonial, CreateTestimonialDTO>().ReverseMap();
		CreateMap<Testimonial, GetTestimonialDTO>().ReverseMap();
		CreateMap<Testimonial, ResultTestimonialDTO>().ReverseMap();
		CreateMap<Testimonial, UpdateTestimonialDTO>().ReverseMap();
	}
}
