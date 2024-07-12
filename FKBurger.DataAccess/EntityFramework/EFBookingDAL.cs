using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFBookingDAL : GenericRepository<Booking>, IBookingDAL
{
    public EFBookingDAL(FKBurgerDBContext context) : base(context) { }

    public void BookingStatusApproved(int id)
    {
        using var context = new FKBurgerDBContext();
        var values = context.Bookings.Find(id);
        values.Description = "Rezervasyon Onaylandı";
        context.SaveChanges();
    }

    public void BookingStatusCancelled(int id)
    {
        using var context = new FKBurgerDBContext();
        var values = context.Bookings.Find(id);
        values.Description = "Rezervasyon İptal Edildi";
        context.SaveChanges();
    }
}
