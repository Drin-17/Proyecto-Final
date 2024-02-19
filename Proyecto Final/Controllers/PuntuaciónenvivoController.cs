using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Models.DataSources;

namespace Proyecto_Final.Controllers
{
    public class PuntuaciónenvivoController : Controller
    {
        public IActionResult Tracks()
        {
            PuntuaciónenvivoDatasources datasources = new PuntuaciónenvivoDatasources("https://livescore6.p.rapidapi.com/matches/v2/list-live" , 
                "0b48cdd280mshfd5964c03d1d55cp1e7ad9jsn441b77dea4eb");
            var tracks = datasources.getListTrack("");
            return View(tracks);
        }
    }
}
