using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.Abstract;
public interface IProductDAL : IGenericDAL<Product>
{
    List<Product> GetProductsWithCategories();
    int ProductCount();
    int ProductCountByCategoryNameHamburger();
    int ProductCountByCategoryNameDrink();
    decimal ProductPriceAvg();
    string ProductNameByMaxPrice();
    string ProductNameByMinPrice();
    decimal ProductAvgPriceByHamburger();
    decimal ProductPriceBySteakBurger();
    decimal TotalPriceByDrinkCategory();
    decimal TotalPriceBySaladCategory();
}
