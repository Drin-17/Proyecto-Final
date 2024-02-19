using Microsoft.AspNetCore.Mvc;
using Poryecto_Final.Models.DataSources;

namespace Poryecto_Final.Controllers
{
    public class ExerciseController : Controller
    {
        public IActionResult Examples()
        {
            ExerciseDataSource dataSource = new ExerciseDataSource("https://exercises-by-api-ninjas.p.rapidapi.com/v1/exercises", "92ccc86447msh7c7503e0d86936dp19405fjsn3172383c9ea3");
            var Examples = dataSource.getListExample("biceps");
            return View();
        }
    }
}

