using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.Abstract;
public interface IMoneyCaseDAL : IGenericDAL<MoneyCase>
{
    decimal TotalMoneyCaseAmount();
}
