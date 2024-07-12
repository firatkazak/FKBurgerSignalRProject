using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFFeatureDAL : GenericRepository<Feature>, IFeatureDAL
{
	public EFFeatureDAL(FKBurgerDBContext context) : base(context) { }
}
