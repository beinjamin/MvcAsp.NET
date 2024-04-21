using Microsoft.AspNetCore.Mvc;

namespace MvcAsp.Net.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View("Index");
    }
}