using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;

public class Format:BaseAuditableEntity
{
    public Format()
    {
        BookFormats=new HashSet<BookFormat>();
    }
    public string Name { get; set; } = null!;
    public IEnumerable<BookFormat> BookFormats { get; set; }
}