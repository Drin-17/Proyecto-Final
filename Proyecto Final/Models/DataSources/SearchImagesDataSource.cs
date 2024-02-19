using RestSharp;
using Proyecto_Final.Models.Unsplash;
using ProyectoFinal.Models.Unsplash;

namespace Proyecto_Final.Models.DataSources
{
    public class SearchImagesDataSource : BaseDataSourceImages
    {
        public SearchImagesDataSource(string url_base)
        {
            _urlBase = url_base;
        }

        public List<SearchImages> getListImages(string query, string client_id)
        {
            _client = new RestClient(_urlBase + "&query=" + query + "&client_id=" + client_id);
            var request = new RestRequest("", Method.Get);
            var response = _client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.ErrorMessage ?? response.Content);
            }
            var imageResponse = SearchImagesResponse.FromJson(response.Content!);
            List<SearchImages> images = SearchImagesMapper.searchImagesResponseToSearchImagesList(imageResponse.Results);

            return images;
        }
    }
}
