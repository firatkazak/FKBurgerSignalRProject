using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.ViewComponents.DefautComponents;
public class _DefaultBookATablePartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}