using Proyecto_Final.Models.Receta;

namespace Poryecto_Final.Models.Receta
{
    public class RecetaMapper
    {
        public static RecetaTrack ConvertToReceta(D recetaResponse)
        {
            if (recetaResponse == null)
                return null;

            return new RecetaTrack
            {
                Id = recetaResponse.Id,
                Title = recetaResponse.Title,
                Ingredients = recetaResponse.Ingredients,
                Instructions = recetaResponse.Instructions,
                Image = recetaResponse.Image
            };
        }

        public static List<RecetaTrack> ConvertToRecetas(List<D> recetasResponse)
        {
            if (recetasResponse == null)
                return null;

            return recetasResponse.Select(ConvertToReceta).ToList();
        }
    }
}


