using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.Controllers;
public class AdminLayoutController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
