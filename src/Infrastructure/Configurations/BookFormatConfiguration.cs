using BookShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop.Infrastructure.Configurations
{
    public class BookFormatConfiguration : IEntityTypeConfiguration<BookFormat>
    {
        public void Configure(EntityTypeBuilder<BookFormat> builder)
        {
            builder.HasOne(b => b.Book)
                .WithMany(bf => bf.BookFormats)
                .HasForeignKey(x => x.BookId);
            builder.HasOne(f => f.Format)
                .WithMany(bf => bf.BookFormats)
                .HasForeignKey(x => x.FormatId);
        }
    }
}
