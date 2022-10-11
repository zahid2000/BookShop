namespace BookShop.Domain.Entities;

public class Discount:BaseEntity
{
    public Discount()
    {
        Prices = new HashSet<Price>();
    }
    public double DiscountPercent { get; set; }
    public ICollection<Price> Prices { get; set; }
}