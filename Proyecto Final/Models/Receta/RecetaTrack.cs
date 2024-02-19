namespace Proyecto_Final.Models.Receta
{
    public class RecetaTrack
    {
        public long Id { get; set; }
        public string Title { get; set;  }
        public Dictionary<string, string> Ingredients { get; set; }
        public string Instructions { get; set; }
         public string Image { get; set; }

        internal static List<RecetaTrack> FromJson(string? content)
        {
            throw new NotImplementedException();
        }
    }
}

