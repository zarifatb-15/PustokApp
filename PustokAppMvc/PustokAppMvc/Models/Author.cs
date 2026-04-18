using PustokAppMvc.Models.Common;

namespace PustokAppMvc.Models;

public class Author:BaseEntity
{
    public string FullName { get; set; }
    public string ImageUrl { get; set; }
    public List<Book> Books { get; set; }
}