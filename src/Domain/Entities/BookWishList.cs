using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;

public class BookWishList:BaseEntity
{
    public int BookId { get; set; }
    public Book Book { get; set; }
    public int WishListId { get; set; }
    public WishList WishList { get; set; }
}
