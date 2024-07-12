using FKBurger.Business.Abstract;
using FKBurger.DataAccess.Abstract;
using FKBurger.Entity.Entities;

namespace FKBurger.Business.Concrete;
public class MessageManager : IMessageService
{
    private readonly IMessageDAL _messageDAL;

    public MessageManager(IMessageDAL messageDAL)
    {
        _messageDAL = messageDAL;
    }

    public void TAdd(Message entity)
    {
        _messageDAL.Add(entity);
    }

    public void TDelete(Message entity)
    {
        _messageDAL.Delete(entity);
    }

    public Message TGetById(int id)
    {
        return _messageDAL.GetById(id);
    }

    public List<Message> TGetListAll()
    {
        return _messageDAL.GetListAll();
    }

    public void TUpdate(Message entity)
    {
        _messageDAL.Update(entity);
    }
}
