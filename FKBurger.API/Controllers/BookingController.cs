using FKBurger.Business.Abstract;
using FKBurger.DTO.BookingDTO;
using FKBurger.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookingController : ControllerBase
{
    private readonly IBookingService _bookingService;

    public BookingController(IBookingService bookingService)
    {
        _bookingService = bookingService;
    }
    [HttpGet]
    public IActionResult BookingList()
    {
        var values = _bookingService.TGetListAll();
        return Ok(values);
    }
    [HttpPost]
    public IActionResult CreateBooking(CreateBookingDTO createBookingDTO)
    {
        Booking booking = new Booking()
        {
            Mail = createBookingDTO.Mail,
            Date = createBookingDTO.Date,
            Name = createBookingDTO.Name,
            PersonCount = createBookingDTO.PersonCount,
            Phone = createBookingDTO.Phone,
            Description = createBookingDTO.Description
        };
        _bookingService.TAdd(booking);
        return Ok("Rezervasyon Yapıldı");
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteBooking(int id)
    {
        var value = _bookingService.TGetById(id);
        _bookingService.TDelete(value);
        return Ok("Rezervasyon Silindi");
    }
    [HttpPut]
    public IActionResult UpdateBooking(UpdateBookingDTO updateBookingDTO)
    {
        Booking booking = new Booking()
        {
            Mail = updateBookingDTO.Mail,
            BookingID = updateBookingDTO.BookingID,
            Name = updateBookingDTO.Name,
            PersonCount = updateBookingDTO.PersonCount,
            Phone = updateBookingDTO.Phone,
            Date = updateBookingDTO.Date
        };
        _bookingService.TUpdate(booking);
        return Ok("Rezervasyon Güncellendi");
    }
    [HttpGet("{id}")]
    public IActionResult GetBooking(int id)
    {
        var value = _bookingService.TGetById(id);
        return Ok(value);
    }
    [HttpGet("BookingStatusApproved/{id}")]
    public IActionResult BookingStatusApproved(int id)
    {
        _bookingService.BookingStatusApproved(id);
        return Ok("Rezervasyon Açıklaması Değiştirildi");
    }
    [HttpGet("BookingStatusCancelled/{id}")]
    public IActionResult BookingStatusCancelled(int id)
    {
        _bookingService.BookingStatusCancelled(id);
        return Ok("Rezervasyon Açıklaması Değiştirildi");
    }
}