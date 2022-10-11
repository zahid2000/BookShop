
namespace BookShop.Domain.Entities.Auth;
public class AppUser : IdentityUser
{
    public AppUser()
    {
        Books=new HashSet<Book>();
        Addresses = new HashSet<Address>();
        Reviews = new HashSet<Review>();
        Orders = new HashSet<Order>();
    }   

    public int CartId { get; set; }
    public Cart? Cart { get; set; }
    public int WishListId { get; set; }
    public WishList? WishList { get; set; }
    public ICollection<Book> Books { get; set; }
    public ICollection<Address> Addresses{ get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<Order> Orders { get; set; }
}
