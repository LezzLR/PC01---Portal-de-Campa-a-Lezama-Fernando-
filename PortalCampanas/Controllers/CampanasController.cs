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
    }
}