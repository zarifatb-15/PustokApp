using System.ComponentModel.DataAnnotations;
using PustokAppMvc.Models.Common;

namespace PustokAppMvc.Models;

public class Author:BaseEntity
{
    [Required]
    [MaxLength(20)]
    public string FullName { get; set; }
    public string ImageUrl { get; set; }
    public List<Book> Books { get; set; }
}