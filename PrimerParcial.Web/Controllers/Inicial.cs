using Microsoft.AspNetCore.Mvc;

namespace PrimerParcial.Web.Controllers
{
    public class Inicial : Controller
    {
        public IActionResult Hola()
        {
            return View();
        }
    }
}
