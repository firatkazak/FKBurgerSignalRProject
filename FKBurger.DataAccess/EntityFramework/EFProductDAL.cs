using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace FKBurger.DataAccess.EntityFramework;
public class EFProductDAL : GenericRepository<Product>, IProductDAL
{
    public EFProductDAL(FKBurgerDBContext context) : base(context)
    {
    }

    public List<Product> GetProductsWithCategories()
    {
        var context = new FKBurgerDBContext();
        var values = context.Products.Include(x => x.Category).ToList();
        return values;
    }

    public decimal ProductAvgPriceByHamburger()
    {
        using var context = new FKBurgerDBContext();
        return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Average(w => w.Price);
    }

    public int ProductCount()
    {
        using var context = new FKBurgerDBContext();
        return context.Products.Count();
    }

    public int ProductCountByCategoryNameDrink()
    {
        using var context = new FKBurgerDBContext();
        return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "İçecek").Select(z => z.CategoryID).FirstOrDefault())).Count();
    }

    public int ProductCountByCategoryNameHamburger()
    {
        using var context = new FKBurgerDBContext();
        return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();
    }

    public string ProductNameByMaxPrice()
    {
        using var context = new FKBurgerDBContext();
        return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
    }

    public string ProductNameByMinPrice()
    {
        using var context = new FKBurgerDBContext();
        return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
    }

    public decimal ProductPriceAvg()
    {
        using var context = new FKBurgerDBContext();
        return context.Products.Average(x => x.Price);
    }

    public decimal ProductPriceBySteakBurger()
    {
        using var context = new FKBurgerDBContext();
        return context.Products.Where(x => x.ProductName == "Steak Burger").Select(y => y.Price).FirstOrDefault();
    }

    public decimal TotalPriceByDrinkCategory()
    {
        using var context = new FKBurgerDBContext();
        int id = context.Categories.Where(x => x.CategoryName == "İçecek").Select(y => y.CategoryID).FirstOrDefault();
        return context.Products.Where(x => x.CategoryID == id).Sum(y => y.Price);
    }

    public decimal TotalPriceBySaladCategory()
    {
        using var context = new FKBurgerDBContext();
        int id = context.Categories.Where(x => x.CategoryName == "Salata").Select(y => y.CategoryID).FirstOrDefault();
        return context.Products.Where(x => x.CategoryID == id).Sum(y => y.Price);
    }
}

