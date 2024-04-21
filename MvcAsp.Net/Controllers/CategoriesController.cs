using Microsoft.AspNetCore.Mvc;

namespace MvcAsp.Net.Controllers;

public class CategoriesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Edit(int id)
    {
        return new ContentResult
        {
            Content = id.ToString()
        };
    }
}