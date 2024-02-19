using Newtonsoft.Json;
using Poryecto_Final.Models.Airbnb;

namespace Proyecto_Final.Models.Airbnb
{
    public class AirbnbTrack
    {
        public string ID { get; set; }

        public string name { get; set; }

        public Uri Url { get; set; }

        public double Bathrooms { get; set; }

        public long Bedrooms { get; set; }

        public List<Uri> Images { get; set; }

        public string Address { get; set; }

        public long Rate { get; set; }

        public string Title { get; set; }

        public long Amount { get; set; }
    }
}
