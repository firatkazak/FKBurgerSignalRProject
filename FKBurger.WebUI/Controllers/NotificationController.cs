using FKBurger.WebUI.DTOs.NotificationDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace FKBurger.WebUI.Controllers;
public class NotificationController : Controller
{
	private readonly IHttpClientFactory _httpClientFactory;

	public NotificationController(IHttpClientFactory httpClientFactory)
	{
		_httpClientFactory = httpClientFactory;
	}

	public async Task<IActionResult> Index()
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.GetAsync("https://localhost:7100/api/Notification");
		if (responseMessage.IsSuccessStatusCode)
		{
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultNotificationDTO>>(jsonData);
			return View(values);
		}
		return View();
	}
	
	[HttpGet]
	public IActionResult CreateNotification()
	{
		return View();
	}
	
	[HttpPost]
	public async Task<IActionResult> CreateNotification(CreateNotificationDTO createNotificationDTO)
	{
		var client = _httpClientFactory.CreateClient();
		var jsonData = JsonConvert.SerializeObject(createNotificationDTO);
		StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
		var responseMessage = await client.PostAsync("https://localhost:7100/api/Notification", stringContent);
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
	
	public async Task<IActionResult> DeleteNotification(int id)
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.DeleteAsync($"https://localhost:7100/api/Notification/{id}");
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}
	
	[HttpGet]
	public async Task<IActionResult> UpdateNotification(int id)
	{
		var client = _httpClientFactory.CreateClient();
		var responseMessage = await client.GetAsync($"https://localhost:7100/api/Notification/{id}");
		if (responseMessage.IsSuccessStatusCode)
		{
			var jsonData = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<UpdateNotificationDTO>(jsonData);
			return View(values);
		}
		return View();
	}
	
	[HttpPost]
	public async Task<IActionResult> UpdateNotification(UpdateNotificationDTO updateNotificationDTO)
	{
		var client = _httpClientFactory.CreateClient();
		var jsonData = JsonConvert.SerializeObject(updateNotificationDTO);
		StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
		var responseMessage = await client.PutAsync("https://localhost:7100/api/Notification/", stringContent);
		if (responseMessage.IsSuccessStatusCode)
		{
			return RedirectToAction("Index");
		}
		return View();
	}

	public async Task<IActionResult> NotificationStatusChangeToTrue(int id)
	{
		var client = _httpClientFactory.CreateClient();
		await client.GetAsync($"https://localhost:7100/api/Notification/NotificationStatusChangeToTrue/{id}");
		return RedirectToAction("Index");
	}

	public async Task<IActionResult> NotificationStatusChangeToFalse(int id)
	{
		var client = _httpClientFactory.CreateClient();
		await client.GetAsync($"https://localhost:7100/api/Notification/NotificationStatusChangeToFalse/{id}");
		return RedirectToAction("Index");
	}
}
