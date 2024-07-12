using System.ComponentModel.DataAnnotations.Schema;

namespace FKBurger.Entity.Entities;
public class Order
{
    public int OrderID { get; set; }
    public string TableNumber { get; set; }
    public string Description { get; set; }

    [Column(TypeName = "Date")]
    public DateTime OrderDate { get; set; }
    public decimal TotalPrice { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
}
