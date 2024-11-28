using Microsoft.AspNetCore.Mvc;
using PrimerParcial.Web.Models;
using PrimerParcial.Logica;
using PrimerParcial.Entidades;
namespace PrimerParcial.Web.Controllers
{
    public class BarcosController : Controller
    {
        private readonly IBarcoLogica _barcoLogica;
        public BarcosController(IBarcoLogica barcoLogica)
        {
            _barcoLogica = barcoLogica;
        }
        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(BarcoViewModel barco)
        {
            if (!ModelState.IsValid)
            {
                return View(barco);
            }
            _barcoLogica.RegistrarBarco(BarcoViewModel.ToBarco(barco));
            return RedirectToAction("Listado");
        }
        [HttpGet]
        public IActionResult Listado()
        {
            var barcos = _barcoLogica.Listado(); // Obtiene los datos (puede ser List<Barco>)
            if (barcos == null || !barcos.Any()) // Si no hay datos, evita que sea null
            {
                barcos = new List<Barco>(); // Retorna una lista vacía en lugar de null
            }

            // Convierte a BarcoViewModel si es necesario
            var barcosViewModel = barcos.Select(BarcoViewModel.FromBarco).ToList();
            return View(barcosViewModel);
        }
    }
}
