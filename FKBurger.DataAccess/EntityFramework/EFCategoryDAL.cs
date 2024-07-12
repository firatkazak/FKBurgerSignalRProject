using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFCategoryDAL : GenericRepository<Category>, ICategoryDAL
{
    public EFCategoryDAL(FKBurgerDBContext context) : base(context) { }

    public int ActiveCategoryCount()
    {
        using var context = new FKBurgerDBContext();
        return context.Categories.Where(x => x.CategoryStatus == true).Count();
    }

    public int CategoryCount()
    {
        using var context = new FKBurgerDBContext();
        return context.Categories.Count();
    }

    public int PassiveCategoryCount()
    {
        using var context = new FKBurgerDBContext();
        return context.Categories.Where(x => x.CategoryStatus == false).Count();
    }
}
