using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.Controllers;
public class StatisticController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
