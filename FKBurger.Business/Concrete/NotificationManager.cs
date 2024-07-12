using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class NotificationManager : INotificationService
{
    private readonly INotificationDAL _notificationDAL;

    public NotificationManager(INotificationDAL notificationDAL)
    {
        _notificationDAL = notificationDAL;
    }

    public void TAdd(Notification entity)
    {
        _notificationDAL.Add(entity);
    }

    public void TDelete(Notification entity)
    {
        _notificationDAL.Delete(entity);
    }

    public List<Notification> TGetAllNotificationByFalse()
    {
        return _notificationDAL.GetAllNotificationByFalse();
    }

    public Notification TGetById(int id)
    {
        return _notificationDAL.GetById(id);
    }

    public List<Notification> TGetListAll()
    {
        return _notificationDAL.GetListAll();
    }

    public int TNotificationCountByStatusFalse()
    {
        return _notificationDAL.NotificationCountByStatusFalse();
    }

    public void TNotificationStatusChangeToFalse(int id)
    {
        _notificationDAL.NotificationStatusChangeToFalse(id);
    }

    public void TNotificationStatusChangeToTrue(int id)
    {
        _notificationDAL.NotificationStatusChangeToTrue(id);
    }

    public void TUpdate(Notification entity)
    {
        _notificationDAL.Update(entity);
    }
}
