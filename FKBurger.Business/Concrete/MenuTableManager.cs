using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class MenuTableManager : IMenuTableService
{
    private readonly IMenuTableDAL _menuTableDAL;

    public MenuTableManager(IMenuTableDAL menuTableDAL)
    {
        _menuTableDAL = menuTableDAL;
    }

    public void TAdd(MenuTable entity)
    {
        _menuTableDAL.Add(entity);
    }

    public void TDelete(MenuTable entity)
    {
        _menuTableDAL.Delete(entity);
    }

    public MenuTable TGetById(int id)
    {
        return _menuTableDAL.GetById(id);
    }

    public List<MenuTable> TGetListAll()
    {
        return _menuTableDAL.GetListAll();
    }

    public int TMenuTableCount()
    {
        return _menuTableDAL.MenuTableCount();
    }

    public void TUpdate(MenuTable entity)
    {
        _menuTableDAL.Update(entity);
    }
}
