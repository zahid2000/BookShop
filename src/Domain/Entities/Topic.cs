using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;

public class Topic:BaseEntity
{
    public Topic()
    {
        Books = new HashSet<Book>();
    }
    public string Name { get; set; } = null!;
    public ICollection<Book> Books { get; set; }
}
