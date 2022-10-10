using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;

public class BookLanguage:BaseEntity
{
    public int BookId { get; set; }
    public Book Book { get; set; } 
    public int LanguageId { get; set; }
    public Language Language { get; set; } 
}
