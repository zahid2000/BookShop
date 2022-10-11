namespace BookShop.Domain.Entities;

public class Order:BaseAuditableEntity
{
    public double TotalPrice { get; set; }
    public ICollection<CartItem> CartItems { get; set; }
    public Address OrderAddress { get; set; }
    public int OrderMethodId { get; set; }
    public OrderMethod OrderMethod { get; set; }
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; }

}
