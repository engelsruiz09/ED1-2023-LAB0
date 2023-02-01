using ED1_Lab0.Models;
using Microsoft.AspNetCore.Mvc;

namespace ED1_Lab0.Controllers
{
    [Route("[controller]")] // ("[persona]")] 
    public class PersonasController : Controller
    {
        [HttpGet]
        [Route("[ejemplopersona]")]
        public Persona ObtenerPersona()
        {
            Persona ejemplo = new Persona()
            {
                Nombre = "chepe",
                Profesion = "Medico",
                Edad = 48
            };
            return ejemplo;
        }
    }
}
