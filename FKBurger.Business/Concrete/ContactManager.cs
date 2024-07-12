using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class ContactManager : IContactService
{
	private readonly IContactDAL _contactDAL;

	public ContactManager(IContactDAL contactDAL)
	{
		_contactDAL = contactDAL;
	}

	public void TAdd(Contact entity)
	{
		_contactDAL.Add(entity);
	}

	public void TDelete(Contact entity)
	{
		_contactDAL.Delete(entity);
	}

	public Contact TGetById(int id)
	{
		return _contactDAL.GetById(id);
	}

	public List<Contact> TGetListAll()
	{
		return _contactDAL.GetListAll();
	}

	public void TUpdate(Contact entity)
	{
		_contactDAL.Update(entity);
	}
}
