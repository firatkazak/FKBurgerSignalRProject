using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.Abstract;
public interface INotificationDAL : IGenericDAL<Notification>
{
    int NotificationCountByStatusFalse();
    List<Notification> GetAllNotificationByFalse();
    void NotificationStatusChangeToTrue(int id);
    void NotificationStatusChangeToFalse(int id);
}
