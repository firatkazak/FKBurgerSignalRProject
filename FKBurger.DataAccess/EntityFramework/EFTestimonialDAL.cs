using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFTestimonialDAL : GenericRepository<Testimonial>, ITestimonialDAL
{
	public EFTestimonialDAL(FKBurgerDBContext context) : base(context) { }
}
