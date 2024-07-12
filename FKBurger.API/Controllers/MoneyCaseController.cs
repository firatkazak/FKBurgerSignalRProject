using FKBurger.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoneyCaseController : ControllerBase
{
    private readonly IMoneyCaseService _moneyCaseService;

    public MoneyCaseController(IMoneyCaseService moneyCaseService)
    {
        _moneyCaseService = moneyCaseService;
    }

    [HttpGet]
    public IActionResult TotalMoneyCaseAmount()
    {
        return Ok(_moneyCaseService.TTotalMoneyCaseAmount());
    }
}
