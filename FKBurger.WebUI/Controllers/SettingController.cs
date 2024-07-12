using FKBurger.Entity.Entities;
using FKBurger.WebUI.DTOs.IdentityDTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.WebUI.Controllers;
public class SettingController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    public SettingController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var values = await _userManager.FindByNameAsync(User.Identity.Name);
        UserEditDTO userEditDTO = new UserEditDTO();
        userEditDTO.Surname = values.Surname;
        userEditDTO.Name = values.Name;
        userEditDTO.Username = values.UserName;
        userEditDTO.Mail = values.Email;
        return View(userEditDTO);
    }
    [HttpPost]
    public async Task<IActionResult> Index(UserEditDTO userEditDTO)
    {
        if (userEditDTO.Password == userEditDTO.ConfirmPassword)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = userEditDTO.Name;
            user.Surname = userEditDTO.Surname;
            user.Email = userEditDTO.Mail;
            user.UserName = userEditDTO.Username;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditDTO.Password);
            await _userManager.UpdateAsync(user);
            return RedirectToAction("Index", "Category");
        }
        return View();
    }
}