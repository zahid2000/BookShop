namespace BookShop.Domain.Entities;

public class OrderMethod:BaseEntity
{
    public OrderMethod()
    {
        Orders = new HashSet<Order>();
    }
    public string Name { get; set; }
    public ICollection<Order> Orders { get; set; }
}