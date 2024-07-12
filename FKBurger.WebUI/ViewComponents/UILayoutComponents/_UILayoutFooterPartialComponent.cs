using FKBurger.WebUI.DTOs.ContactDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FKBurger.WebUI.ViewComponents.UILayoutComponents;
public class _UILayoutFooterPartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _UILayoutFooterPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7100/api/Contact");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultContactDTO>>(jsonData);
        return View(values);
    }
}
