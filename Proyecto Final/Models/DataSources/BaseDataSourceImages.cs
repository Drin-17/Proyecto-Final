using RestSharp;
using static System.Net.WebRequestMethods;

namespace Proyecto_Final.Models.DataSources
{
    public class BaseDataSourceImages
    {
        protected RestClient? _client;
        protected string _urlBase = "https://api.unsplash.com/search/photos?page=1";
    }
}
