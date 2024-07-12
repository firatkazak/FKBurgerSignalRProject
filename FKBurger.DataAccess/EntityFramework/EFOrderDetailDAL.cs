using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.Concrete;
using FKBurger.DataAccess.Repositories;
using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.EntityFramework;
public class EFOrderDetailDAL : GenericRepository<OrderDetail>, IOrderDetailDAL
{
    public EFOrderDetailDAL(FKBurgerDBContext context) : base(context) { }
}
