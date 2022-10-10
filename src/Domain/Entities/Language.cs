using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;


public class Language:BaseAuditableEntity
{
    public Language()
    {
        BookLanguages=new HashSet<BookLanguage>();
    }
    public string Name { get; set; } = null!;
    public IEnumerable<BookLanguage> BookLanguages { get; set; }
}
