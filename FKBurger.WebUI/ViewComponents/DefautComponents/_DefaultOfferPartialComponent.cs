using FKBurger.WebUI.DTOs.DiscountDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FKBurger.WebUI.ViewComponents.DefautComponents;
public class _DefaultOfferPartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _DefaultOfferPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7100/api/Discount/");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultDiscountDTO>>(jsonData);
        return View(values);
    }
}