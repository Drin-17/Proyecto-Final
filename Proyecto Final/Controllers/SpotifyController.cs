using Microsoft.AspNetCore.Mvc;
using Proyecto_Final.Models.DataSources;
using Proyecto_Final.Models.Spotify;

public class SpotifyController : Controller
{
    private readonly SpotifyDatasource _datasource;

    public SpotifyController()
    {
        _datasource = new SpotifyDatasource("https://spotify81.p.rapidapi.com/download_track", "009149e067msh1a3d5e5ba68e089p14237fjsnf3a94377e9cd");
    }

    public IActionResult Tracks(string query)
    {
        SpotifyTrack track = null;
        string errorMessage = null;

        if (!string.IsNullOrEmpty(query))
        {
            try
            {
                track = _datasource.getListTrack(query);
            }
            catch (Exception ex)
            {
                errorMessage = "Lo sentimos, ha ocurrido un error al buscar la canción.";
            }
        }
        else
        {
            errorMessage = "Por favor, ingrese el nombre de una canción para buscar.";
        }

        ViewData["ErrorMessage"] = errorMessage;
        return View(track);
    }
}
