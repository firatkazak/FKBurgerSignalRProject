using FKBurger.WebUI.DTOs.ProductDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FKBurger.WebUI.ViewComponents.DefautComponents;
public class _DefaultOurMenuPartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _DefaultOurMenuPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7100/api/Product");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultProductDTO>>(jsonData);
        return View(values);
    }
}