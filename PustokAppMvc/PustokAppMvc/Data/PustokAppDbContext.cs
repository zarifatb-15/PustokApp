using Microsoft.EntityFrameworkCore;
using PustokAppMvc.Models;
namespace PustokAppMvc.Data;

public class PustokAppDbContext(DbContextOptions<PustokAppDbContext>options):DbContext(options)
{
    public DbSet <Slider> Sliders { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<BookTag> BookTags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PustokAppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}