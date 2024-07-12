using FKBurger.WebUI.DTOs.TestimonialDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace FKBurger.WebUI.Controllers;
public class TestimonialController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public TestimonialController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7100/api/Testimonial");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultTestimonialDTO>>(jsonData);
            return View(values);
        }
        return View();
    }

    [HttpGet]
    public IActionResult CreateTestimonial()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateTestimonial(CreateTestimonialDTO createTestimonialDTO)
    {
        createTestimonialDTO.Status = true;
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(createTestimonialDTO);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7100/api/Testimonial", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }

    public async Task<IActionResult> DeleteTestimonial(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync($"https://localhost:7100/api/Testimonial/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> UpdateTestimonial(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7100/api/Testimonial/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateTestimonialDTO>(jsonData);
            return View(values);
        }
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDTO updateTestimonialDTO)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(updateTestimonialDTO);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("https://localhost:7100/api/Testimonial/", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
}