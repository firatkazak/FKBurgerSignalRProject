using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class DiscountManager : IDiscountService
{
    private readonly IDiscountDAL _discountDAL;

    public DiscountManager(IDiscountDAL discountDAL)
    {
        _discountDAL = discountDAL;
    }

    public void TAdd(Discount entity)
    {
        _discountDAL.Add(entity);
    }

    public void TChangeStatusToFalse(int id)
    {
        _discountDAL.ChangeStatusToFalse(id);
    }

    public void TChangeStatusToTrue(int id)
    {
        _discountDAL.ChangeStatusToTrue(id);
    }

    public void TDelete(Discount entity)
    {
        _discountDAL.Delete(entity);
    }

    public Discount TGetById(int id)
    {
        return _discountDAL.GetById(id);
    }

    public List<Discount> TGetListAll()
    {
        return _discountDAL.GetListAll();
    }

    public List<Discount> TGetListByStatusTrue()
    {
        return _discountDAL.GetListByStatusTrue();
    }

    public void TUpdate(Discount entity)
    {
        _discountDAL.Update(entity);
    }
}
