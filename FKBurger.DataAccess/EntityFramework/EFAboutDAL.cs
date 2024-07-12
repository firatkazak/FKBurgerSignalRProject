using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFAboutDAL : GenericRepository<About>, IAboutDAL
{
	public EFAboutDAL(FKBurgerDBContext context) : base(context) { }
}
