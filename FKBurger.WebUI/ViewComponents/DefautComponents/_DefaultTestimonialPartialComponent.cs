using FKBurger.WebUI.DTOs.TestimonialDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FKBurger.WebUI.ViewComponents.DefautComponents;
public class _DefaultTestimonialPartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _DefaultTestimonialPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7100/api/Testimonial");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultTestimonialDTO>>(jsonData);
        return View(values);
    }
}