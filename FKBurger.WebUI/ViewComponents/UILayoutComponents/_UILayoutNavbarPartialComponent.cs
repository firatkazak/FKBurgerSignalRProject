using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.ViewComponents.UILayoutComponents;
public class _UILayoutNavbarPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}