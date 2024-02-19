using Poryecto_Final.Models.Exercise;
using ProyectoFinal.Models.Exercise;

namespace Poryecto_Final.Models.DataSources
{
    using Proyecto_Final.Models.DataSources;
    using RestSharp;
    public class ExerciseDataSource :BaseDataSource
    {
        public ExerciseDataSource(string url_base ,string api_key)

        {
            _urlBase=url_base;
            _api_key = api_key;
        }
        public ExerciseExample getListExample(string query)
        { 

            _client = new RestClient(_urlBase + "?muscle=" + query);
            var request = new RestRequest("", Method.Get);
            request.AddHeader("X-RapidAPI-Key",_api_key);
            request.AddHeader("X-RapidAPI-Host", "exercises-by-api-ninjas.p.rapidapi.com");
            var response = _client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception(response.ErrorMessage ?? response.Content);
            }
            
            var exerciseResponse = ExerciseExampleResponse.FromJson(response.Content!);

            return ExerciseMapper.ExerciseExampleResponseToExerciseExample(exerciseResponse);
        }

        
    }
}
