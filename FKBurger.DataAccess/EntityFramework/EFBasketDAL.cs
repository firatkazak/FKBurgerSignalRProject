using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace FKBurger.DataAccess.EntityFramework;
public class EFBasketDAL : GenericRepository<Basket>, IBasketDAL
{
    public EFBasketDAL(FKBurgerDBContext context) : base(context) { }

    public List<Basket> GetBasketByMenuTableNumber(int id)
    {
        using var context = new FKBurgerDBContext();
        var values = context.Baskets.Where(x => x.MenuTableID == id).Include(y => y.Product).ToList();
        return values;
    }
}
