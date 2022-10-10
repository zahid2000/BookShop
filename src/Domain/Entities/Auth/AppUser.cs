
namespace BookShop.Domain.Entities.Auth;
public class AppUser : IdentityUser
{
    public AppUser()
    {
        Books=new HashSet<Book>();
    }
    public int CountryId { get; set; }
    public Country Country { get; set; } = null!;

    public string? City { get; set; }
    public string? Address { get; set; }
    public string? Appartment{ get; set; }
    public string? ZIPCode { get; set; }

    public int CartId { get; set; }
    public Cart? Cart { get; set; }
    public int WishListId { get; set; }
    public WishList? WishList { get; set; }

    public IEnumerable<Book> Books { get; set; }
}
