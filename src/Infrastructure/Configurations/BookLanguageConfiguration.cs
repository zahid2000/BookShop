using BookShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop.Infrastructure.Configurations
{
    public class BookLanguageConfiguration : IEntityTypeConfiguration<BookLanguage>
    {
        public void Configure(EntityTypeBuilder<BookLanguage> builder)
        {
            builder.HasOne(b => b.Book)
                .WithMany(bl => bl.BookLanguages)
                .HasForeignKey(x => x.BookId);
            builder.HasOne(l => l.Language)
                .WithMany(bl => bl.BookLanguages)
                .HasForeignKey(x => x.LanguageId);
        }
    }
}
