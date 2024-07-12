﻿using FKBurger.WebUI.DTOs.SocialMediaDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FKBurger.WebUI.ViewComponents.UILayoutComponents;
public class _UILayoutSocialMediaPartialComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;
    public _UILayoutSocialMediaPartialComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7100/api/SocialMedia");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultSocialMediaDTO>>(jsonData);
            return View(values);
        }
        return View();
    }
}