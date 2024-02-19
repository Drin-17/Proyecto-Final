

using Newtonsoft.Json;
using Poryecto_Final.Models.Airbnb;
using Proyecto_Final.Models.Airbnb;
using Proyecto_Final.Models.DataSource;
using Proyecto_Final.Models.DataSources;
using RestSharp;

namespace Proyecto_Final.Models.DataSources
{
    public class AirbnbDataSourcecs : BaseDataSource
    {
        public AirbnbDataSourcecs(string url_Base, string api_key)
        {
            _api_key = api_key;
            _urlBase = url_Base;

        }
        public List<AirbnbTrack> getListTrack(string location, string checkin, string checkout, int adults)
        {
            
            string query = $"location={location}&checkin={checkin}&checkout={checkout}&adults={adults}";

            _client = new RestClient(_urlBase + "?" + query);
            var request = new RestRequest("",Method.Get);
            request.AddHeader("X-RapidAPI-Key", _api_key);
            request.AddHeader("X-RapidAPI-Host", "airbnb13.p.rapidapi.com");

            var response = _client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.ErrorMessage ?? response.Content);
            }

            var listResponse = AirbnbResponse.FromJson(response.Content!);
            List<AirbnbTrack> tracks = AirbnbMapper.AirbnbResponseToAirbnbTracks(listResponse);


            return  tracks;
        }
    }

    
}
