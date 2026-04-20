using PustokAppMvc.Models;

namespace PustokAppMvc.ViewModels;

public class BookDeteailVm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int DiscountPercentage { get; set; }
    public decimal Price { get; set; }
    public string Code{ get; set; }
    public bool InStock { get; set; }
    public bool IsFeatured { get; set; }
    public bool IsNew { get; set; }
}