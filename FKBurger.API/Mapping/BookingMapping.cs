using AutoMapper;
using FKBurger.DTO.BookingDTO;
using FKBurger.Entity.Entities;

namespace FKBurger.API.Mapping;
public class BookingMapping : Profile
{
	public BookingMapping()
	{
		CreateMap<Booking, CreateBookingDTO>().ReverseMap();
		CreateMap<Booking, GetBookingDTO>().ReverseMap();
		CreateMap<Booking, ResultBookingDTO>().ReverseMap();
		CreateMap<Booking, UpdateBookingDTO>().ReverseMap();
	}
}