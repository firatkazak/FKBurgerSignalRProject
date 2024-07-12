using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFContactDAL : GenericRepository<Contact>, IContactDAL
{
	public EFContactDAL(FKBurgerDBContext context) : base(context) { }
}
