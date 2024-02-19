
using ProyectoFinal.models.FreeToPLay;

namespace Poryecto_Final.Models.Freetoplay
{
    public class FreeToPlayMapper
    {
        public static FreeToPlay MapToModel(FreeToPlayResponse response)
        {
            if (response == null)
                return null;

            return new FreeToPlay
            {
                Id = response.Id,
                Title = response.Title,
                Thumbnail = response.Thumbnail,
                ShortDescription = response.ShortDescription,
                GameUrl = response.GameUrl,
                Publisher = response.Publisher,
                Developer = response.Developer,
                ReleaseDate = response.ReleaseDate,
                FreetogameProfileUrl = response.FreetogameProfileUrl
            };
        }

        public static List<FreeToPlay> MapToModelList(List<FreeToPlayResponse> responseList)
        {
            return responseList?.ConvertAll(MapToModel);
        }


    }
}
