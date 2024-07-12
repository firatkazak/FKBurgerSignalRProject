using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.ViewComponents.UILayoutComponents;
public class _UILayoutHeaderPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}