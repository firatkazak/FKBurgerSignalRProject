using FKBurger.Entity.Entities;

namespace FKBurger.Business.Abstract;
public interface ICategoryService : IGenericService<Category>
{
    public int TCategoryCount();
    int TActiveCategoryCount();
    int TPassiveCategoryCount();
}
