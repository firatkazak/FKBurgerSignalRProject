using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.Abstract;
public interface IOrderDAL : IGenericDAL<Order>
{
    int TotalOrderCount();
    int ActiveOrderCount();
    decimal LastOrderPrice();
    decimal TodayTotalPrice();
}
