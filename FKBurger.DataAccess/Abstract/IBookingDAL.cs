using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.Abstract;
public interface IBookingDAL : IGenericDAL<Booking>
{
    void BookingStatusApproved(int id);
    void BookingStatusCancelled(int id);
}
