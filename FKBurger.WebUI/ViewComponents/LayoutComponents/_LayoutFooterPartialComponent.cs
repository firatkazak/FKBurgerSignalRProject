using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.ViewComponents.LayoutComponents;
public class _LayoutFooterPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}