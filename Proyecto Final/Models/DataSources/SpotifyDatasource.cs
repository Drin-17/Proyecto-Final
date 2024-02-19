namespace Proyecto_Final.Models.DataSources
{
    using Proyecto_Final.Models.Spotify;
    using RestSharp;
    public class SpotifyDatasource : BaseDataSource
    {

        public SpotifyDatasource(string url_base, string api_key) 
        {
            _urlBase = url_base;
            _api_key= api_key;
        }

        public SpotifyTrack getListTrack(string query)
        {
            _client = new RestClient(_urlBase + "?q=" + query);
            var request = new RestRequest("", Method.Get);
            request.AddHeader("X-RapidAPI-Key", _api_key);
            request.AddHeader("X-RapidAPI-Host", "spotify81.p.rapidapi.com");
            var response = _client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.ErrorMessage ?? response.Content);
            }
            var spotifyResponse =SpotifyTrackResponse.FromJson(response.Content);
            return SpotifyMapper.spotifyResponseToSpotifyTrack(spotifyResponse);
        }
    }
}
