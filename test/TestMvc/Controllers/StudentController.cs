
using Microsoft.AspNetCore.Mvc;
namespace TestMvc.Controllers;
public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string fullname)
    {
        ViewBag.message="Chao mung" + fullname;
        return View();
    }

    public IActionResult Cuong()
    {
        return View();
    }
}