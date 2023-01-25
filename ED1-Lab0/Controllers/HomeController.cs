using ED1_Lab0.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ED1_Lab0.Controllers
{
    //metodos que retornan IactionResult
    public class HomeController : Controller //home controller hereda de controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Persona persona1; 
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger; //para ver errores
            persona1 = new Persona();//constructor
            persona1.Edad = 18;
            persona1.Nombre = "engels";
            persona1.Profesion = "Ingeniero";
        }
        /*
        public IActionResult Index()
        {
            // return View(); // es como el main en program.cs
        }
        */
        public Persona Index()
        {
            // return View(); // es como el main en program.cs
            return persona1;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}