using FKBurger.WebUI.DTOs.MessageDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace FKBurger.WebUI.Controllers;
[AllowAnonymous]
public class DefaultController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;
    public DefaultController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public PartialViewResult SendMessage()
    {
        return PartialView();
    }
    [HttpPost]
    public async Task<IActionResult> SendMessage(CreateMessageDTO createMessageDTO)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(createMessageDTO);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7100/api/Message", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
}
