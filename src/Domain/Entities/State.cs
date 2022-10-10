using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;

public class State:BaseEntity
{
    public string Name { get; set; } = null!;
    public int CountryId { get; set; }
    public Country? Country { get; set; }

}