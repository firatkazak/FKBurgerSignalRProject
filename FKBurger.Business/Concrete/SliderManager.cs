using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class SliderManager : ISliderService
{
    private readonly ISliderDAL _sliderDAL;

    public SliderManager(ISliderDAL sliderDAL)
    {
        _sliderDAL = sliderDAL;
    }

    public void TAdd(Slider entity)
    {
        _sliderDAL.Add(entity);
    }

    public void TDelete(Slider entity)
    {
        _sliderDAL.Delete(entity);
    }

    public Slider TGetById(int id)
    {
        return _sliderDAL.GetById(id);
    }

    public List<Slider> TGetListAll()
    {
        return _sliderDAL.GetListAll();
    }

    public void TUpdate(Slider entity)
    {
        _sliderDAL.Update(entity);
    }
}
