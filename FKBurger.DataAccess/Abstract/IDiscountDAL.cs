using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.Abstract;
public interface IDiscountDAL : IGenericDAL<Discount>
{
    void ChangeStatusToTrue(int id);
    void ChangeStatusToFalse(int id);
    List<Discount> GetListByStatusTrue();
}
