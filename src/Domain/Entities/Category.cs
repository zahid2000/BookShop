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
    public int? SubCategoryId { get; set; }
    public Category SubCategory { get; set; }
    public bool isMain { get; set; }
    public ICollection<Category> SubCategories { get; set; }
    public ICollection<Book> Books { get; set; }

}
