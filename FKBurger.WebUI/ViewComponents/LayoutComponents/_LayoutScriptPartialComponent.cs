﻿using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.ViewComponents.LayoutComponents;
public class _LayoutScriptPartialComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}