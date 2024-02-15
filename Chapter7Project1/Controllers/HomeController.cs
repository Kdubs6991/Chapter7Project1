using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Chapter7Project1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        var contact = new Dictionary<string, string> {
            { "Phone", "555-123-4567" },
            { "Email", "info@epicwebsite.com" }
        };
        return View(contact);
    }

    public IActionResult About()
    {
        return View();
    }

    
}