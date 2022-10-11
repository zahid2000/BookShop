namespace BookShop.Domain.Entities;

public class Price:BaseAuditableEntity
{
    public Price()
    {
        Languages = new HashSet<Language>();
        Formats = new HashSet<Format>();
    }

    public double BookPrice { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public int DiscountId { get; set; }
    public Discount? Discount { get; set; }
    public ICollection<Language> Languages { get; set; }
    public ICollection<Format> Formats { get; set; }
}
