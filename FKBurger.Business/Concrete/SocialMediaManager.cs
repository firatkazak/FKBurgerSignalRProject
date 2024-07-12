using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class SocialMediaManager : ISocialMediaService
{
	private readonly ISocialMediaDAL _socialMediaDAL;

	public SocialMediaManager(ISocialMediaDAL socialMediaDAL)
	{
		_socialMediaDAL = socialMediaDAL;
	}

	public void TAdd(SocialMedia entity)
	{
		_socialMediaDAL.Add(entity);
	}

	public void TDelete(SocialMedia entity)
	{
		_socialMediaDAL.Delete(entity);
	}

	public SocialMedia TGetById(int id)
	{
		return _socialMediaDAL.GetById(id);
	}

	public List<SocialMedia> TGetListAll()
	{
		return _socialMediaDAL.GetListAll();
	}

	public void TUpdate(SocialMedia entity)
	{
		_socialMediaDAL.Update(entity);
	}
}
