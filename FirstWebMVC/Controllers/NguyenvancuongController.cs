using Microsoft.AspNetCore.Mvc;
namespace FirstWebMVC.Controllers;
public class NguyenvancuongController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}