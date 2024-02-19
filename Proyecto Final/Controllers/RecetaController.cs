using Microsoft.AspNetCore.Mvc;
using Poryecto_Final.Models.DataSources;
using Proyecto_Final.Models.Receta;

namespace Proyecto_Final.Controllers
{
    public class RecetaController : Controller
    {

        public IActionResult Tracks(string query)
        {
            // Supongamos que el parámetro 'query' viene de la solicitud o de algún otro lugar

            // Utiliza el método getListTrack del RecetaDatasources
            RecetaDatasources datasource = new RecetaDatasources("https://food-recipes-with-images.p.rapidapi.com/", "6ce85efbbdmshd8eacd2de4a5391p148c62jsnabfc17fa9e6e");
            var receta= datasource.getListTrack("chicken");

            // Pasa la lista a la vista
            return View(receta);
        }
    }
}