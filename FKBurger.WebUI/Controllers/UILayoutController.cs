using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
