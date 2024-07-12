using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class OrderDetailManager : IOrderDetailService
{
    private readonly IOrderDetailDAL _orderDetailDAL;

    public OrderDetailManager(IOrderDetailDAL orderDetailDAL)
    {
        _orderDetailDAL = orderDetailDAL;
    }

    public void TAdd(OrderDetail entity)
    {
        throw new NotImplementedException();
    }

    public void TDelete(OrderDetail entity)
    {
        throw new NotImplementedException();
    }

    public OrderDetail TGetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<OrderDetail> TGetListAll()
    {
        throw new NotImplementedException();
    }

    public void TUpdate(OrderDetail entity)
    {
        throw new NotImplementedException();
    }
}
