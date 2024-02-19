using RestSharp;

namespace Proyecto_Final.Models.DataSources
{
    public class BaseDataSource
    {
        protected RestClient? _client;
        protected string _api_key;
        protected string _urlBase = "https://spotify81.p.rapidapi.com/download_track";
    }
}
