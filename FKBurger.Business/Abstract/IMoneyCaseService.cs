using FKBurger.Entity.Entities;

namespace FKBurger.Business.Abstract;
public interface IMoneyCaseService : IGenericService<MoneyCase>
{
    decimal TTotalMoneyCaseAmount();
}
