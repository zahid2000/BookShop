using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;

public class Book : BaseAuditableEntity
{
    public Book()
    {
        BookImages = new HashSet<BookImage>();
   
        Reviews=new HashSet<Review>();
    }
    public string BookName { get; set; } = null!;
    public string? Description { get; set; }
    public double DiscountPercent { get; set; }
    public int Quantity { get; set; }

    //One to Many
    public int CategoryId { get; set; }
    public Category? Category { get; set; } 
    public int TopicId { get; set; }
    public Topic Topic { get; set; }
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public int WishListId { get; set; }
    public WishList WishList { get; set; }
    public int CartItemId { get; set; }
    public CartItem CartItem { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public int PriceId { get; set; }
    public Price Price { get; set; }
    //Many to One
    public ICollection<BookImage> BookImages { get; set; }


    //Many to Many 
  
    public ICollection<Review> Reviews { get; set; }


}
