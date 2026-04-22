using PustokAppMvc.Models.Common;

namespace PustokAppMvc.Models;

public class BookImage:BaseEntity
{
    public string Image { get; set; }
    public Book Book { get; set; }
    public Guid BookId { get; set; }
    public  string  ImageUrl { get; set; }
}