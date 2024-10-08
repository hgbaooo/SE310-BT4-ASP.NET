using Microsoft.AspNetCore.Mvc;
using QuanLySanPham.Models;

namespace QuanLySanPham.Controllers;

public class ProductController(MyDbContext context) : Controller
{
    // GET
    public IActionResult Index()
    {
        var dsCatalogs = context.Products.ToList();

        return View(dsCatalogs);
    }
}