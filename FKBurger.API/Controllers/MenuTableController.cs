using FKBurger.Business.Abstract;
using FKBurger.DTO.MenuTableDTO;
using FKBurger.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MenuTableController : ControllerBase
{
    private readonly IMenuTableService _menuTableService;
    public MenuTableController(IMenuTableService menuTableService)
    {
        _menuTableService = menuTableService;
    }
    [HttpGet("MenuTableCount")]
    public IActionResult MenuTableCount()
    {
        return Ok(_menuTableService.TMenuTableCount());
    }
    [HttpGet]
    public IActionResult MenuTableList()
    {
        var values = _menuTableService.TGetListAll();
        return Ok(values);
    }
    [HttpPost]
    public IActionResult CreateMenuTable(CreateMenuTableDTO createMenuTableDTO)
    {
        MenuTable menuTable = new MenuTable()
        {
            Name = createMenuTableDTO.Name,
            Status = false
        };
        _menuTableService.TAdd(menuTable);
        return Ok("Masa Başarılı Bir Şekilde Eklendi");
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteMenuTable(int id)
    {
        var value = _menuTableService.TGetById(id);
        _menuTableService.TDelete(value);
        return Ok("Masa Silindi");
    }
    [HttpPut]
    public IActionResult UpdateMenuTable(UpdateMenuTableDTO updateMenuTableDTO)
    {
        MenuTable menuTable = new MenuTable()
        {
            Name = updateMenuTableDTO.Name,
            Status = false,
            MenuTableID = updateMenuTableDTO.MenuTableID
        };
        _menuTableService.TUpdate(menuTable);
        return Ok("Masa Bilgisi Güncellendi");
    }
    [HttpGet("{id}")]
    public IActionResult GetMenuTable(int id)
    {
        var value = _menuTableService.TGetById(id);
        return Ok(value);
    }
}
