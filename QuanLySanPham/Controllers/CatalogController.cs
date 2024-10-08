using Microsoft.AspNetCore.Mvc;
using QuanLySanPham.Models;

namespace QuanLySanPham.Controllers;

public class CatalogController(MyDbContext context) : Controller
{
    // GET
    public IActionResult Index()
    {
        var dsCatalogs = context.Catalogs.ToList();

        return View(dsCatalogs);
    }
}