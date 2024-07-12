using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.Abstract;
public interface ICategoryDAL : IGenericDAL<Category>
{
    int CategoryCount();
    int ActiveCategoryCount();
    int PassiveCategoryCount();
}
