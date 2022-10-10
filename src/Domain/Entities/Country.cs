using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;

public class Country:BaseEntity
{
    public Country()
    {
        AppUsers=new HashSet<AppUser>();
        States=new HashSet<State>();
    }
    public string Name { get; set; } = null!;
    public IEnumerable<AppUser> AppUsers { get; set; }
    public IEnumerable<State> States { get; set; }
}
