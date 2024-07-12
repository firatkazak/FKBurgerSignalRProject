using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFMenuTableDAL : GenericRepository<MenuTable>, IMenuTableDAL
{
    public EFMenuTableDAL(FKBurgerDBContext context) : base(context) { }

    public int MenuTableCount()
    {
        using var context = new FKBurgerDBContext();
        return context.MenuTables.Count();
    }
}
