namespace FKBurger.DTO.ProductDTO;
public class ResultProductWithCategoryDTO
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public bool ProductStatus { get; set; }
    public string CategoryName { get; set; }
}
