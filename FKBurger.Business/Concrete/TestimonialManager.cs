using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class TestimonialManager : ITestimonialService
{
	private readonly ITestimonialDAL _testimonialDAL;

	public TestimonialManager(ITestimonialDAL testimonialDAL)
	{
		_testimonialDAL = testimonialDAL;
	}

	public void TAdd(Testimonial entity)
	{
		_testimonialDAL.Add(entity);
	}

	public void TDelete(Testimonial entity)
	{
		_testimonialDAL.Delete(entity);
	}

	public Testimonial TGetById(int id)
	{
		return _testimonialDAL.GetById(id);
	}

	public List<Testimonial> TGetListAll()
	{
		return _testimonialDAL.GetListAll();
	}

	public void TUpdate(Testimonial entity)
	{
		_testimonialDAL.Update(entity);
	}
}
