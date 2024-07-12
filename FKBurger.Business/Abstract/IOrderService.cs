using FKBurger.Entity.Entities;

namespace FKBurger.Business.Abstract;
public interface IOrderService : IGenericService<Order>
{
    int TTotalOrderCount();
    int TActiveOrderCount();
    decimal TLastOrderPrice();
    decimal TTodayTotalPrice();
}
