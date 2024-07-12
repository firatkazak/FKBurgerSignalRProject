using FKBurger.WebUI.DTOs.BookingDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace FKBurger.WebUI.Controllers;
public class BookATableController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;
    public BookATableController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(CreateBookingDTO createBookingDTO)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(createBookingDTO);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7100/api/Booking", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index", "Default");
        }
        return View();
    }
}
