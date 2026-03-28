using Microsoft.AspNetCore.Mvc;
using PortalCampanas.Services;
using System.Linq;

namespace PortalCampanas.Controllers
{
    public class CampanasController : Controller
    {
        public IActionResult Index(string filtro)
        {
            var lista = CampanaService.Lista;

            if (!string.IsNullOrEmpty(filtro))
            {
                lista = lista
                    .Where(c => (c.Nombre ?? "")
                    .Contains(filtro, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            return View(lista);
        }

        public IActionResult Detalle(int id)
        {
            var campana = CampanaService.Lista
                .FirstOrDefault(c => c.Id == id);

            return View(campana);
        }
    }
}