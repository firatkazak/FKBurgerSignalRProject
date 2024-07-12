using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.ViewComponents.LayoutComponents;
public class _LayoutNavbarPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
