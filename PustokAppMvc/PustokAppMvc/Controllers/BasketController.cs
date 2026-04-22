using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PustokAppMvc.Services;

namespace PustokAppMvc.Controllers;

public class BasketController : Controller
{
    public BankService _bankService;

    public BasketController(BankService bankService, BankManager bankManager)
    {
        _bankService = bankService;
    }

    public IActionResult Index()
    {
        _bankService.Add();
        
        return Content(""+ _bankService.Balance);
    }

}