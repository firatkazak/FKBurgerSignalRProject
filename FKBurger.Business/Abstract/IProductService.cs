﻿using FKBurger.Entity.Entities;

namespace FKBurger.Business.Abstract;
public interface IProductService : IGenericService<Product>
{
    List<Product> TGetProductsWithCategories();
    int TProductCount();
    int TProductCountByCategoryNameHamburger();
    int TProductCountByCategoryNameDrink();
    decimal TProductPriceAvg();
    string TProductNameByMaxPrice();
    string TProductNameByMinPrice();
    decimal TProductAvgPriceByHamburger();
    decimal TProductPriceBySteakBurger();
    decimal TTotalPriceByDrinkCategory();
    decimal TTotalPriceBySaladCategory();
}
