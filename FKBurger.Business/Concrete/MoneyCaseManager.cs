using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class MoneyCaseManager : IMoneyCaseService
{
    private readonly IMoneyCaseDAL _moneyCaseDAL;

    public MoneyCaseManager(IMoneyCaseDAL moneyCaseDAL)
    {
        _moneyCaseDAL = moneyCaseDAL;
    }

    public void TAdd(MoneyCase entity)
    {
        throw new NotImplementedException();
    }

    public void TDelete(MoneyCase entity)
    {
        throw new NotImplementedException();
    }

    public MoneyCase TGetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<MoneyCase> TGetListAll()
    {
        throw new NotImplementedException();
    }

    public decimal TTotalMoneyCaseAmount()
    {
        return _moneyCaseDAL.TotalMoneyCaseAmount();
    }

    public void TUpdate(MoneyCase entity)
    {
        throw new NotImplementedException();
    }
}
