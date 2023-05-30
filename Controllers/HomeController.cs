using Microsoft.AspNetCore.Mvc;
using TP05_CZERNUSZKA_KOZIUPA.Models;
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
    public IActionResult Habitacion(int sala, string clave){
        if(sala != Escape.GetEstadoJuego()){
            return View("Habitacion"+Escape.GetEstadoJuego());
        }
        else if(sala == 4){
            return View("Victoria");
        }
        else if(Escape.ResolverSala(sala, clave)){
            return View(Escape.GetEstadoJuego());
        }
        else{
            return View("Habitacion"+sala);
        }
    }
    public IActionResult Victoria(){
        return View();
    }
    public IActionResult Creditos(){
        return View();
    }
}
