using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFDiscountDAL : GenericRepository<Discount>, IDiscountDAL
{
    public EFDiscountDAL(FKBurgerDBContext context) : base(context) { }

    public void ChangeStatusToFalse(int id)
    {
        using var context = new FKBurgerDBContext();
        var value = context.Discounts.Find(id);
        value.Status = false;
        context.SaveChanges();
    }

    public void ChangeStatusToTrue(int id)
    {
        using var context = new FKBurgerDBContext();
        var value = context.Discounts.Find(id);
        value.Status = true;
        context.SaveChanges();
    }

    public List<Discount> GetListByStatusTrue()
    {
        using var context = new FKBurgerDBContext();
        var value = context.Discounts.Where(x => x.Status == true).ToList();
        return value;
    }
}
