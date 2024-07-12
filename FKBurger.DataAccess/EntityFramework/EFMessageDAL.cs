using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFMessageDAL : GenericRepository<Message>, IMessageDAL
{
    public EFMessageDAL(FKBurgerDBContext context) : base(context) { }
}
