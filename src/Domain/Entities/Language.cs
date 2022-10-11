using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;


public class Language:BaseAuditableEntity
{
    public Language()
    {
        Books=new HashSet<Book>();
    }
    public string Name { get; set; } = null!;
    public ICollection<Book> Books { get; set; }
}
