using BookShop.Domain.Entities.BaseEntities;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookShop.Domain.Entities;

public class WishList:BaseAuditableEntity
{
    public WishList()
    {
        Books = new HashSet<Book>();
    }
    public int AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    public ICollection<Book> Books { get; set; }
}