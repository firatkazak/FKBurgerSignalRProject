using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.Controllers;
public class MessageController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CLientUserCount()
    {
        return View();
    }
}
