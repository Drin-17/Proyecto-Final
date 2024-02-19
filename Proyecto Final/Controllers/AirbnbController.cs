using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Models.DataSources;
using Proyecto_Final.Models;
using System.Diagnostics;

namespace Proyecto_Final.Controllers
{

    public class AirbnbController : Controller
    {
        

        public IActionResult Information(string location, string checkin, string checkout, int adults)
        {
            AirbnbDataSourcecs dataSource = new AirbnbDataSourcecs("https://airbnb13.p.rapidapi.com/search-location", "7cb3e29e4cmshe3d74e011a35abep1fcf83jsn00b4ff82fffd");

            
            var locations = dataSource.getListTrack(location, checkin, checkout, adults);

           
            return View(locations);
        }

        
    }


}