using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // clients
        var c1 = new Client(01, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");
        var c2 = new Client(02, "William Henry Gates III", "039.618.250-09", "bill@microsoft.com", "Bug");
        var c3 = new Client(03, "Ada Lovelace", "800.777.920-50", "ada@ada.language.com", "Byron");
        var c4 = new Client(04, "Linus Torvalds", "933.622.400-03", "torvalds@osdl.org", "Pinguim");
        var c5 = new Client(05, "Grace Hopper", "911.702.988-00", "grace.hopper@cobol.com", "Loboc");

        ViewBag.clientList = new List<Client> { c1, c2, c3, c4, c5 };


        // suppliers
        var s1 = new Supplier(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        var s2 = new Supplier(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        var s3 = new Supplier(03, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        var s4 = new Supplier(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        var s5 = new Supplier(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

        ViewBag.supplierList = new List<Supplier> { s1, s2, s3, s4, s5 };


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
