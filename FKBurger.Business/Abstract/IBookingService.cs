using FKBurger.Entity.Entities;

namespace FKBurger.Business.Abstract;
public interface IBookingService : IGenericService<Booking>
{
    void BookingStatusApproved(int id);
    void BookingStatusCancelled(int id);
}
