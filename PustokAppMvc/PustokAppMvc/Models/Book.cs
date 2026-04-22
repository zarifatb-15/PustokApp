using System.ComponentModel.DataAnnotations.Schema;
using PustokAppMvc.Models.Common;

namespace PustokAppMvc.Models;

public class Book:BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int DiscountPercentage { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
    public Author Author { get; set; }
    public Guid AuthorId { get; set; }
    public string MainImageUrl { get; set; }
    public string HoverImageUrl { get; set; }
    public bool IsNew { get; set; }
    public bool IsFeatured { get; set; }
    public bool InStock { get; set; }
    public string Code { get; set; }
    public List<BookImage> BookImages { get; set; }
    public List<BookTag> BookTags { get; set; }

    public Book()
    {
        BookImages = [];
        BookTags = [];
    }
}