using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.Controllers
{
    public class ProgressBarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
