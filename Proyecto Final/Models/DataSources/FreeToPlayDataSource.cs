namespace Proyecto_Final.Models.DataSource;

using Poryecto_Final.Models.Freetoplay;
using Proyecto_Final.Models.DataSources;
using ProyectoFinal.models.FreeToPLay;
using RestSharp;
public class FreeToPlayDataSource :BaseDataSource
{
    public FreeToPlayDataSource (string url_base, string api_key )
    {
        _urlBase=url_base;
        _api_key=api_key;

    }

    public List<FreeToPlayResponse> GetListFreeToPlay(string query)
    {
        _client = new RestClient(_urlBase + "?category=" + query);
        var request = new RestRequest(" ", Method.Get);
        request.AddHeader("X-RapidAPI-Key", _api_key);
        request.AddHeader("X-RapidAPI-Host", "free-to-play-games-database.p.rapidapi.com");
        var response = _client.Execute(request);

        if (response.StatusCode != System.Net.HttpStatusCode.OK)
        {
            throw new Exception(response.ErrorMessage ?? response.Content);
        }

        // Devolver la lista deserializada directamente
        return FreeToPlayResponse.FromJson(response.Content!);
    }
}

