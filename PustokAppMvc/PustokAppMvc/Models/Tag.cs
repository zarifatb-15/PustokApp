using PustokAppMvc.Models.Common;

namespace PustokAppMvc.Models;

public class Tag:BaseEntity
{
    public string Name { get; set; }
    public List<BookTag> BookTags{ get; set; }
}