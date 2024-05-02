using Microsoft.AspNetCore.Mvc;
using MvcAsp.Net.Models;

namespace MvcAsp.Net.Controllers;

public class CategoriesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Edit(int? id)
    {
        var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };
        return View(category);
    }
}