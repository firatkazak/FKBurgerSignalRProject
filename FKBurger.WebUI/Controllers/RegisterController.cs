using FKBurger.Entity.Entities;
using FKBurger.WebUI.DTOs.IdentityDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.Controllers;
[AllowAnonymous]
public class RegisterController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    public RegisterController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(RegisterDTO registerDTO)
    {
        var appUser = new AppUser()
        {
            Name = registerDTO.Name,
            Surname = registerDTO.Surname,
            Email = registerDTO.Mail,
            UserName = registerDTO.Username
        };
        var result = await _userManager.CreateAsync(appUser, registerDTO.Password);
        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Login");
        }
        return View();
    }
}
