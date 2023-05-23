using Microsoft.AspNetCore.Mvc;

namespace TP05_CZERNUSZKA_KOZIUPA.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Tutorial(){
        return View();
    }
    public IActionResult Comenzar(){
        return View();
    }
    public IActionResult Habitacion(){
        return View();
    }
}
