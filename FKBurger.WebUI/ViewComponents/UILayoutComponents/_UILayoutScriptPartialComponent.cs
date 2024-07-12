using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.ViewComponents.UILayoutComponents;
public class _UILayoutScriptPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}