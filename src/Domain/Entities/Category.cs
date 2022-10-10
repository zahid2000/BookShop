using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;

public class Category : BaseAuditableEntity
{
    public Category()
    {
        Books = new HashSet<Book>();
    }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public IEnumerable<Book> Books { get; set; }

}
