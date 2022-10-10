using BookShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop.Infrastructure.Configurations
{
    public class BookCartConfiguration : IEntityTypeConfiguration<BookCart>
    {
        public void Configure(EntityTypeBuilder<BookCart> builder)
        {
            builder.HasOne(b => b.Book)
                 .WithMany(bc => bc.BookCarts)
                 .HasForeignKey(x => x.BookId);
            builder.HasOne(w => w.Cart)
                .WithMany(bc => bc.BookCarts)
                .HasForeignKey(x => x.CartId);
        }
    }
}
