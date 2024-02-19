using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Models.DataSource;
using Poryecto_Final.Models.Freetoplay;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.Common;


namespace Proyecto_Final.Controllers
{
    public class FreeToPlayController : Controller
    {
       
            public IActionResult FreeToPlay(string categoria)
            {
                // Establecer la categoría predeterminada si no se proporciona
                if (string.IsNullOrEmpty(categoria))
                {
                    categoria = "strategy";
                }


                FreeToPlayDataSource dataSource = new FreeToPlayDataSource("https://free-to-play-games-database.p.rapidapi.com/api/games", "560084a670msh5de3cbe7a12fc50p11a25ajsna456d2fe54ba");
                try
                {
                    // Establecer la categoría en ViewBag
                    ViewBag.Categoria = categoria;

                    // Obtener la lista de juegos con la categoría proporcionada
                    var freeToPlayList = dataSource.GetListFreeToPlay(categoria);

                    // Pasar la lista de juegos a la vista
                    return View(freeToPlayList);
                }
                catch (Exception ex)
                {
                    // Manejar la excepción de categoría no encontrada
                    return View("Error"); // Puedes redirigir a una página de error específica o manejar de otra manera
                }
            }


        }
    }
