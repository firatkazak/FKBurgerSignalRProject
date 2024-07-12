﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using FKBurger.WebUI.DTOs.ProductDTOs;
using FKBurger.WebUI.DTOs.CategoryDTOs;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FKBurger.WebUI.Controllers;
public class ProductController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public ProductController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7100/api/Product/ProductListWithCategory");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultProductDTO>>(jsonData);
            return View(values);
        }
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> CreateProduct()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7100/api/Category");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultCategoryDTO>>(jsonData);
        List<SelectListItem> values2 = (from x in values
                                        select new SelectListItem
                                        {
                                            Text = x.CategoryName,
                                            Value = x.CategoryID.ToString()
                                        }).ToList();
        ViewBag.v = values2;
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(CreateProductDTO createProductDTO)
    {
        createProductDTO.ProductStatus = true;
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(createProductDTO);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7100/api/Product", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }

    public async Task<IActionResult> DeleteProduct(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync($"https://localhost:7100/api/Product/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> UpdateProduct(int id)
    {

        var client1 = _httpClientFactory.CreateClient();
        var responseMessage1 = await client1.GetAsync("https://localhost:7100/api/Category");
        var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
        var values1 = JsonConvert.DeserializeObject<List<ResultCategoryDTO>>(jsonData1);
        List<SelectListItem> values2 = (from x in values1 select new SelectListItem { Text = x.CategoryName, Value = x.CategoryID.ToString() }).ToList();
        ViewBag.v = values2;

        var client2 = _httpClientFactory.CreateClient();
        var responseMessage2 = await client2.GetAsync($"https://localhost:7100/api/Product/{id}");
        if (responseMessage2.IsSuccessStatusCode)
        {
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values3 = JsonConvert.DeserializeObject<UpdateProductDTO>(jsonData2);
            return View(values3);
        }
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> UpdateProduct(UpdateProductDTO updateProductDTO)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(updateProductDTO);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("https://localhost:7100/api/Product/", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
}