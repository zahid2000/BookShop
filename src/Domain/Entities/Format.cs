using BookShop.Domain.Entities.BaseEntities;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookShop.Domain.Entities;

public class Format:BaseAuditableEntity
{
    public Format()
    {
        Books = new HashSet<Book>();
    }
    public string Name { get; set; } = null!;
    public ICollection<Book> Books { get; set; }
}