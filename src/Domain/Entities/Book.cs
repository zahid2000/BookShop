using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;

public class Book : BaseAuditableEntity
{
    public Book()
    {
        BookImages = new HashSet<BookImage>();
        BookLanguages = new HashSet<BookLanguage>();
        BookFormats = new HashSet<BookFormat>();
        BookWishLists = new HashSet<BookWishList>();
        BookCarts=new HashSet<BookCart>();
    }
    public string BookName { get; set; } = null!;
    public string Author { get; set; }=null!;
    public string? Description { get; set; }
    public double Price { get; set; }
    public double DiscountPercent { get; set; }
    public int Quantity { get; set; }





    //One to Many
    public int CategoryId { get; set; }
    public Category? Category { get; set; } 
    public int TopicId { get; set; }
    public Topic Topic { get; set; }
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; }

    public IEnumerable<BookImage> BookImages { get; set; }


    //Many to Many 
    public IEnumerable<BookLanguage> BookLanguages { get; set; }
    public IEnumerable<BookFormat> BookFormats { get; set; }
    public IEnumerable<BookWishList> BookWishLists { get; set; }
    public IEnumerable<BookCart> BookCarts { get; set; }

}
public class BookCart : BaseEntity
{
    public int BookId { get; set; }
    public Book Book { get; set; }
    public int CartId { get; set; }
    public Cart? Cart { get; set; }
}