using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFSliderDAL : GenericRepository<Slider>, ISliderDAL
{
    public EFSliderDAL(FKBurgerDBContext context) : base(context) { }
}
