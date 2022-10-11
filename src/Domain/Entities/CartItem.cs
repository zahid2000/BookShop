namespace BookShop.Domain.Entities;

public class CartItem:BaseAuditableEntity
{
    public int BookId { get; set; }
    public Book Book { get; set; }
    public int ItemCount { get; set; }
    public int CartId { get; set; }
    public Cart Cart { get; set; }
}
