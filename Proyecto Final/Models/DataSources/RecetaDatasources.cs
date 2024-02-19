using Poryecto_Final.Models.Receta;
using Proyecto_Final.Models.DataSources;
using Proyecto_Final.Models.Receta;
using RestSharp;

namespace Poryecto_Final.Models.DataSources

{
    public class RecetaDatasources: BaseDataSource
    {
         public RecetaDatasources( string url_base, string api_key)
        {
            _urlBase = url_base;
            _api_key = api_key;
            
        }
        public List<RecetaTrack> getListTrack (string query)
        {
            _client = new RestClient(_urlBase + "?q=" + query );
            var request = new RestRequest("", Method.Get);
            request.AddHeader("X-RapidAPI-Key", _api_key);
            request.AddHeader("X-RapidAPI-Host", "food-recipes-with-images.p.rapidapi.com");
            var response =  _client.Execute(request);
            if (response. StatusCode != System.Net.HttpStatusCode.OK)
            {
               throw new Exception(response. ErrorMessage ?? response.Content);
            }
            var recetaTrackResponse = RecetaTrackRespone.FromJson(response.Content);
            var recetaTracks = recetaTrackResponse.D.Select(d => RecetaMapper.ConvertToReceta(d)).ToList();

            return recetaTracks;



        }

    }
}