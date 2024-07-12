using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFSocialMediaDAL : GenericRepository<SocialMedia>, ISocialMediaDAL
{
	public EFSocialMediaDAL(FKBurgerDBContext context) : base(context) { }
}
