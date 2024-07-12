using FKBurger.Entity.Entities;

namespace FKBurger.Business.Abstract;
public interface IMenuTableService : IGenericService<MenuTable>
{
    int TMenuTableCount();
}
