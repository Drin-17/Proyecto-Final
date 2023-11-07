using System.Xml.Linq;

namespace Proyecto_Final.Models.Spotify
{
    public class Spotify
    {
       

        public char url { get; set; }
        public long Id { get; set; }

        public string Name { get; set; }

        public Spotify(char url, long id, string name)
        {
            this.url = url;
            Id = id;
            Name = name;
        }
    }
    


}
