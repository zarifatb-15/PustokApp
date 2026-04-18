using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokAppMvc.Data;
using PustokAppMvc.ViewModels;

namespace PustokAppMvc.Controllers;

public class HomeController (PustokAppDbContext dbContext):Controller
{
    public IActionResult Index()
    {
        HomeVm homeVm = new HomeVm
        {
            Sliders = dbContext.Sliders.ToList(),
            FeaturedBooks = dbContext.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Where(x => x.IsFeatured).ToList(),

            NewBooks = dbContext.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Where(x => x.IsNew).ToList(),

            DiscountedBooks = dbContext.Books
                .Include(x => x.Author)
                .Include(x=>x.BookImages)
                .Where(x=>x.DiscountPercentage>0).ToList()
        };
        return View(homeVm);
    }
}