using FKBurger.Entity.Entities;

namespace FKBurger.DataAccess.Abstract;
public interface IMenuTableDAL : IGenericDAL<MenuTable>
{
    int MenuTableCount();
}
