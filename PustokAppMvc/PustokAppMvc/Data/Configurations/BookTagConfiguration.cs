using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PustokAppMvc.Models;

namespace PustokAppMvc.Data.Configurations;

public class BookTagConfiguration:IEntityTypeConfiguration<BookTag>
{
    public void Configure(EntityTypeBuilder<BookTag> builder)
    {
        builder.HasKey(bt => new { bt.BookId, bt.TagId });
    }
}