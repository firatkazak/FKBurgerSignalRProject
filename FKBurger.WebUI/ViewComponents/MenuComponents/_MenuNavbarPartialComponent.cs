using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.ViewComponents.MenuComponents;
public class _MenuNavbarPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

