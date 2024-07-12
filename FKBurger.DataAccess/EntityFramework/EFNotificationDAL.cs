using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFNotificationDAL : GenericRepository<Notification>, INotificationDAL
{
    public EFNotificationDAL(FKBurgerDBContext context) : base(context) { }

    public List<Notification> GetAllNotificationByFalse()
    {
        using var context = new FKBurgerDBContext();
        return context.Notifications.Where(x => x.Status == false).ToList();
    }

    public int NotificationCountByStatusFalse()
    {
        using var context = new FKBurgerDBContext();
        return context.Notifications.Where(x => x.Status == false).Count();
    }

    public void NotificationStatusChangeToFalse(int id)
    {
        using var context = new FKBurgerDBContext();
        var value = context.Notifications.Find(id);
        value.Status = false;
        context.SaveChanges();
    }

    public void NotificationStatusChangeToTrue(int id)
    {
        using var context = new FKBurgerDBContext();
        var value = context.Notifications.Find(id);
        value.Status = true;
        context.SaveChanges();
    }
}
