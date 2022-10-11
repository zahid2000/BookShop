
namespace BookShop.Domain.Entities;

public class Address:BaseAuditableEntity
{
    public int CountryId { get; set; }
    public Country Country { get; set; } = null!;
    public string? City { get; set; }
    public string? AddressName { get; set; }
    public string? Appartment { get; set; }
    public string? ZIPCode { get; set; }
}