using BookShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop.Infrastructure.Configurations
{
    public class BookWishListConfiguration : IEntityTypeConfiguration<BookWishList>
    {
        public void Configure(EntityTypeBuilder<BookWishList> builder)
        {
            builder.HasOne(b => b.Book)
                 .WithMany(bw => bw.BookWishLists)
                 .HasForeignKey(x => x.BookId);
            builder.HasOne(w => w.WishList)
                .WithMany(bw => bw.BookWishLists)
                .HasForeignKey(x => x.WishListId);
        }
    }
}
