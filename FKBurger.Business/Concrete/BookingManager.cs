using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class BookingManager : IBookingService
{
    private readonly IBookingDAL _bookingDAL;

    public BookingManager(IBookingDAL bookingDAL)
    {
        _bookingDAL = bookingDAL;
    }

    public void BookingStatusApproved(int id)
    {
        _bookingDAL.BookingStatusApproved(id);
    }

    public void BookingStatusCancelled(int id)
    {
        _bookingDAL.BookingStatusCancelled(id);
    }

    public void TAdd(Booking entity)
    {
        _bookingDAL.Add(entity);
    }

    public void TDelete(Booking entity)
    {
        _bookingDAL.Delete(entity);
    }

    public Booking TGetById(int id)
    {
        return _bookingDAL.GetById(id);
    }

    public List<Booking> TGetListAll()
    {
        return _bookingDAL.GetListAll();
    }

    public void TUpdate(Booking entity)
    {
        _bookingDAL.Update(entity);
    }
}
