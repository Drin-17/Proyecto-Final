namespace Proyecto_Final.Models.Unsplash
{
    public class SearchImages
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public Uri Image { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }
        public long Likes { get; set; }
        public List<SearchImages> Imagenes { get; set; }
    }
}
