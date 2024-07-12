using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.ViewComponents.LayoutComponents;
public class _LayoutSidebarPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}