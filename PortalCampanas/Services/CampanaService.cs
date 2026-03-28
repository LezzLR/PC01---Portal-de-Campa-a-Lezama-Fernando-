using PortalCampanas.Models;

namespace PortalCampanas.Services
{
    public class CampanaService
    {
        public static List<Campana> Lista = new List<Campana>
        {
            new Campana
            {
                Id = 1,
                Nombre = "Cyber Electro",
                Categoria = "Electro",
                Estado = "Vigente",
                FechaInicio = DateTime.Now.AddDays(-2),
                FechaFin = DateTime.Now.AddDays(5),
                DescuentoPct = 20,
                Canal = "Web",
                Descripcion = "Ofertas en electrodomésticos"
            },

            new Campana
            {
                Id = 2,
                Nombre = "Moda Verano",
                Categoria = "Moda",
                Estado = "Próxima",
                FechaInicio = DateTime.Now.AddDays(10),
                FechaFin = DateTime.Now.AddDays(20),
                DescuentoPct = 15,
                Canal = "App",
                Descripcion = "Ropa de temporada"
            }
        };
    }
}