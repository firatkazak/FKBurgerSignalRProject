using FKBurger.Entity.Entities;

namespace FKBurger.Business.Abstract;
public interface IBasketService : IGenericService<Basket>
{
    List<Basket> TGetBasketByMenuTableNumber(int id);
}
