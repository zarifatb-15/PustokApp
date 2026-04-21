using Microsoft.AspNetCore.Mvc;
using PustokAppMvc.Data;
using Microsoft.EntityFrameworkCore;
using PustokAppMvc.Models;
using PustokAppMvc.ViewModels;
namespace PustokAppMvc.Controllers;
public class BooksController(PustokAppDbContext dbContext):Controller
{
    public IActionResult Details(Guid id)
    {
        var book = dbContext.Books
            .Include(x => x.Author)
            .Include(x => x.BookImages)
            .Include(x => x.BookTags)
            .ThenInclude(x => x.Tag)
            .FirstOrDefault(b => b.Id == id);

        if (book == null)
        {
            return NotFound();
        }

        BookVm bookVm = new()
        {
            Book = book,
            RelatedBooks = dbContext.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Where(b => b.AuthorId == book.AuthorId && b.Id != book.Id)
                .Take(4)
                .ToList()
        };
        return View(bookVm);

    }

    public IActionResult BookModal(Guid id)
    {
        var book = dbContext.Books
            .Include(x => x.Author)
            .Include(x => x.BookImages)
            .Include(x => x.BookTags)
            .ThenInclude(x => x.Tag)
            .FirstOrDefault(x => x.Id == id);
        if (book == null)
            return NotFound();

        return PartialView("_BookModalPartialView", book);
    }
}
