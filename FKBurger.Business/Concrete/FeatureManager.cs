using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class FeatureManager : IFeatureService
{
	private readonly IFeatureDAL _featureDAL;

	public FeatureManager(IFeatureDAL featureDAL)
	{
		_featureDAL = featureDAL;
	}

	public void TAdd(Feature entity)
	{
		_featureDAL.Add(entity);
	}

	public void TDelete(Feature entity)
	{
		_featureDAL.Delete(entity);
	}

	public Feature TGetById(int id)
	{
		return _featureDAL.GetById(id);
	}

	public List<Feature> TGetListAll()
	{
		return _featureDAL.GetListAll();
	}

	public void TUpdate(Feature entity)
	{
		_featureDAL.Update(entity);
	}
}
