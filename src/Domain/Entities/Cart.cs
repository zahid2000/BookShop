using BookShop.Domain.Entities.BaseEntities;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookShop.Domain.Entities;

public class Cart:BaseAuditableEntity
{
    public Cart()
    {
        CartItems = new HashSet<CartItem>();
    }
    public int AppUserId { get; set; }   
    public AppUser? AppUser { get; set; }
    public ICollection<CartItem> CartItems { get; set; }

}
