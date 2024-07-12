using FKBurger.WebUI.DTOs.BasketDTOs;
using FKBurger.WebUI.DTOs.ProductDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace FKBurger.WebUI.Controllers;
public class MenuController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;
    public MenuController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7100/api/Product");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultProductDTO>>(jsonData);
        return View(values);
    }
    [HttpPost]
    public async Task<IActionResult> AddBasket(int id)
    {
        CreateBasketDTO createBasketDto = new CreateBasketDTO();
        createBasketDto.ProductID = id;
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(createBasketDto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7100/api/Basket", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return Json(createBasketDto);
    }
}