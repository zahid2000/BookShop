using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;

public class WishList:BaseAuditableEntity
{
    public WishList()
    {
        BookWishLists = new HashSet<BookWishList>();
    }
    public int AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    public IEnumerable<BookWishList> BookWishLists { get; set; }
}