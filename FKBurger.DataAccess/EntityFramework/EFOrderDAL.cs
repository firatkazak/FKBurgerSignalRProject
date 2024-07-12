using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFOrderDAL : GenericRepository<Order>, IOrderDAL
{
    public EFOrderDAL(FKBurgerDBContext context) : base(context) { }

    public int ActiveOrderCount()
    {
        using var context = new FKBurgerDBContext();
        return context.Orders.Where(x => x.Description == "Müşteri Masada").Count();
    }

    public decimal LastOrderPrice()
    {
        using var context = new FKBurgerDBContext();
        return context.Orders.OrderByDescending(x => x.OrderID).Take(1).Select(y => y.TotalPrice).FirstOrDefault();
    }

    public decimal TodayTotalPrice()
    {
        using var context = new FKBurgerDBContext();
        DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        var todayPrice = context.Orders.Where(x => x.OrderDate == today && x.Description == "Hesap Kapatıldı").Sum(x => x.TotalPrice);
        return todayPrice;
    }

    public int TotalOrderCount()
    {
        using var context = new FKBurgerDBContext();
        return context.Orders.Count();
    }
}
