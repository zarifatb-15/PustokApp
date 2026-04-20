using PustokAppMvc.Models;

namespace PustokAppMvc.ViewModels;

public class BookVm
{
    public Book Book { get; set; }
    public List<Book> RelatedBooks { get; set; }
}