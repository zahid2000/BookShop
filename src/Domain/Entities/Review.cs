namespace BookShop.Domain.Entities;

public class Review:BaseAuditableEntity
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Rate { get; set; }

    public int BookId { get; set; }
    public Book Book { get; set; }
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; }
}