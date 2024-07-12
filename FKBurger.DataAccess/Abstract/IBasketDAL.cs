using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.Abstract;
public interface IBasketDAL : IGenericDAL<Basket>
{
    List<Basket> GetBasketByMenuTableNumber(int id);
}
