using BookShop.Domain.Entities.Auth;
using BookShop.Domain.Entities.BaseEntities;

namespace BookShop.Domain.Entities;

public class Country:BaseEntity
{
    public Country()
    {
        Addresses = new HashSet<Address>();
        States=new HashSet<State>();
    }
    public string Name { get; set; } = null!;
    public ICollection<Address> Addresses { get; set; }
    public ICollection<State> States { get; set; }
}
