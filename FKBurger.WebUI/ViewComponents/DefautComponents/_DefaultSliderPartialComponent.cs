using FKBurger.WebUI.DTOs.SliderDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FKBurger.WebUI.ViewComponents.DefautComponents;
public class _DefaultSliderPartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _DefaultSliderPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7100/api/Slider");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultSliderDTO>>(jsonData);
        return View(values);
    }
}
