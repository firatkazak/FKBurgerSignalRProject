using FKBurger.WebUI.DTOs.AboutDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FKBurger.WebUI.ViewComponents.DefautComponents;
public class _DefaultAboutPartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _DefaultAboutPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7100/api/About");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultAboutDTO>>(jsonData);
        return View(values);
    }
}