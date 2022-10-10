using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;

public class Cart:BaseAuditableEntity
{
    public Cart()
    {
        BookCarts = new HashSet<BookCart>();
    }
    public int AppUserId { get; set; }
    public bool IsBought { get; set; }
    public AppUser AppUser { get; set; }
    public IEnumerable<BookCart> BookCarts { get; set; }


}
