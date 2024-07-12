using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class CategoryManager : ICategoryService
{
	private readonly ICategoryDAL _categoryDAL;

	public CategoryManager(ICategoryDAL categoryDAL)
	{
		_categoryDAL = categoryDAL;
	}

    public int TActiveCategoryCount()
    {
        return _categoryDAL.ActiveCategoryCount();
    }

    public void TAdd(Category entity)
	{
		_categoryDAL.Add(entity);
	}

    public int TCategoryCount()
    {
		return _categoryDAL.CategoryCount();
    }

    public void TDelete(Category entity)
	{
		_categoryDAL.Delete(entity);
	}

	public Category TGetById(int id)
	{
		return _categoryDAL.GetById(id);
	}

	public List<Category> TGetListAll()
	{
		return _categoryDAL.GetListAll();
	}

    public int TPassiveCategoryCount()
    {
        return _categoryDAL.PassiveCategoryCount();
    }

    public void TUpdate(Category entity)
	{
		_categoryDAL.Update(entity);
	}
}
