using ProyectoFinal.Models.Unsplash;

namespace Proyecto_Final.Models.Unsplash
{
    public class SearchImagesMapper
    {
        public static List<SearchImages> searchImagesResponseToSearchImagesList(List<Result> response)
        {
            if(response == null || response.Count == null)
                return null;

            List<SearchImages> searchImagesList = new List<SearchImages>();

            foreach (var result in response)
            {
                var searchImage = new SearchImages
                {
                    Id = result.Id,
                    Image = result.Urls.Full,
                    Description = result.Description,
                    Width = result.Width,
                    Height = result.Height,
                    Likes = result.Likes
                };

                searchImagesList.Add(searchImage);
            }

            return searchImagesList;
        }

    }
}
