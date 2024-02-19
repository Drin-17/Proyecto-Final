
namespace Proyecto_Final.Models.DataSources
{
    using Proyecto_Final.Models.Puntuaciónenvivo;
    using Proyecto_Final.Models.Puntuaciónenvivo;
    using RestSharp;
    public class PuntuaciónenvivoDatasources : BaseDataSource
    {
        public PuntuaciónenvivoDatasources(string url_base, string api_key)
        {
            _urlBase = url_base;
            _api_key = api_key;         
        }
        public List<PuntuaciónenvivoTrack> getListTrack(string query)
        {
            _client = new RestClient(_urlBase + "?q=" + query);
            var request = new RestRequest("",Method.Get);
            request.AddHeader("X-RapidAPI-Key", _api_key);
            request.AddHeader("X-RapidAPI-Host", "livescore6.p.rapidapi.com");
            var response = _client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)

            {

                throw new Exception(response.ErrorMessage ?? response.Content);
            }

            var listResponse = PuntuaciónenvivoTrackResponse. FromJson(response.Content!);

            var tracks = PuntuaciónenvivoMapper.PuntuaciónenvivosResponseToPuntuaciónenvivosTracks(listResponse);

            return tracks;
        }
    }
}
