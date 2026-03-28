using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Services;

namespace PortalCampanas.Controllers
{
    public class CampanasController : Controller
    {
        public IActionResult Index()
        {
            var lista = CampanaService.Lista;
            return View(lista);
        }

        public IActionResult Detalle(int id)
        {
            var campana = CampanaService.Lista
                .FirstOrDefault(c => c.Id == id);

            return View(campana);
        }
        public IActionResult Resumen()
        {
            var lista = CampanaService.Lista;

            var resumen = lista
                .GroupBy(c => c.Estado)
                .Select(g => new
                {
                    Estado = g.Key,
                    Cantidad = g.Count()
                })
                .ToList();

            return View(resumen);
        }
    }
    
}