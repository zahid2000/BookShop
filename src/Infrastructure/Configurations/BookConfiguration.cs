using BookShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookShop.Infrastructure.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(b => b.BookName).HasMaxLength(200).IsRequired(true);
            builder.Property(b => b.Author).HasMaxLength(100).IsRequired(true);
            builder.Property(b => b.Price).IsRequired(true);
            builder.Property(b => b.CategoryId).IsRequired(true);
            builder.Property(b => b.AppUserId).IsRequired(true);

            builder.HasOne(c => c.Category)
                .WithMany(b => b.Books)
                .HasForeignKey(x => x.CategoryId);

            builder.HasOne(t => t.Topic)
                .WithMany(b => b.Books)
                .HasForeignKey(t => t.TopicId);

            builder.HasOne(a => a.AppUser)
                .WithMany(b => b.Books)
                .HasForeignKey(x => x.AppUserId);


        }
    }
}
