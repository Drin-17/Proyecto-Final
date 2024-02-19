using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Models.DataSources;
using static Proyecto_Final.Controllers.SearchImagesController;

namespace Proyecto_Final.Controllers
{
    public class SearchImagesController : Controller
    {
        public IActionResult Search(string filtro)
        {
            if (string.IsNullOrEmpty(filtro))
            {
                filtro = "aesthetic";
            }
            SearchImagesDataSource datasource = new SearchImagesDataSource("https://api.unsplash.com/search/photos?page=1");
            var images = datasource.getListImages(filtro, "mnvt99kLOCmIfKZpcnaeW6-oBpgz5-6goFiCwqwzubo");
            ViewBag.CurriculumUrl = "https://galileapachecocv.000webhostapp.com/";

            return View(images);

        }
    }
}

