using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class BasketManager : IBasketService
{
    private readonly IBasketDAL _basketDAL;

    public BasketManager(IBasketDAL basketDAL)
    {
        _basketDAL = basketDAL;
    }

    public void TAdd(Basket entity)
    {
        _basketDAL.Add(entity);
    }

    public void TDelete(Basket entity)
    {
        _basketDAL.Delete(entity);
    }

    public List<Basket> TGetBasketByMenuTableNumber(int id)
    {
        return _basketDAL.GetBasketByMenuTableNumber(id);
    }

    public Basket TGetById(int id)
    {
        return _basketDAL.GetById(id);
    }

    public List<Basket> TGetListAll()
    {
        return _basketDAL.GetListAll();
    }

    public void TUpdate(Basket entity)
    {
        _basketDAL.Update(entity);
    }
}
