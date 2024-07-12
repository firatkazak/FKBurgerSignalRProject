using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.ViewComponents.LayoutComponents;
public class _LayoutHeaderPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}