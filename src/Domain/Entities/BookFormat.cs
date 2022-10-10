using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;

public class BookFormat:BaseEntity
{
    public int BookId { get; set; }
    public Book Book { get; set; } 
    public int FormatId { get; set; }
    public Format Format { get; set; } 
}