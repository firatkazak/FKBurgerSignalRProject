using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class ProductManager : IProductService
{
    private readonly IProductDAL _productDAL;

    public ProductManager(IProductDAL productDAL)
    {
        _productDAL = productDAL;
    }

    public string TProductNameByMaxPrice()
    {
        return _productDAL.ProductNameByMaxPrice();
    }

    public string TProductNameByMinPrice()
    {
        return _productDAL.ProductNameByMinPrice();
    }

    public void TAdd(Product entity)
    {
        _productDAL.Add(entity);
    }

    public void TDelete(Product entity)
    {
        _productDAL.Delete(entity);
    }

    public Product TGetById(int id)
    {
        return _productDAL.GetById(id);
    }

    public List<Product> TGetListAll()
    {
        return _productDAL.GetListAll();
    }

    public List<Product> TGetProductsWithCategories()
    {
        return _productDAL.GetProductsWithCategories();
    }

    public int TProductCount()
    {
        return _productDAL.ProductCount();
    }

    public int TProductCountByCategoryNameDrink()
    {
        return _productDAL.ProductCountByCategoryNameDrink();
    }

    public int TProductCountByCategoryNameHamburger()
    {
        return _productDAL.ProductCountByCategoryNameHamburger();
    }

    public decimal TProductPriceAvg()
    {
        return _productDAL.ProductPriceAvg();
    }

    public void TUpdate(Product entity)
    {
        _productDAL.Update(entity);
    }

    public decimal TProductAvgPriceByHamburger()
    {
        return _productDAL.ProductAvgPriceByHamburger();
    }

    public decimal TProductPriceBySteakBurger()
    {
        return _productDAL.ProductPriceBySteakBurger();
    }

    public decimal TTotalPriceByDrinkCategory()
    {
        return _productDAL.TotalPriceByDrinkCategory();
    }

    public decimal TTotalPriceBySaladCategory()
    {
        return _productDAL.TotalPriceBySaladCategory();
    }
}
