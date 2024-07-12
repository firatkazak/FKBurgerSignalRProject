using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFMoneyCaseDAL : GenericRepository<MoneyCase>, IMoneyCaseDAL
{
    public EFMoneyCaseDAL(FKBurgerDBContext context) : base(context) { }

    public decimal TotalMoneyCaseAmount()
    {
        using var context = new FKBurgerDBContext();
        return context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
    }
}
