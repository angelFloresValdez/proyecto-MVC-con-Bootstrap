using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using pagina_Bootstrap.Models;

namespace pagina_Bootstrap.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
     public IActionResult BotonesAlerta()
    {
        return View();
    }
     public IActionResult Imagenes()
    {
        return View();
    }
       public IActionResult Tablas()
    {
        return View();
    }
       public IActionResult Carousel()
    {
        return View();
    }
   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
