using Proyecto_Final.Models.Airbnb;
using System.Collections.Generic;
using System.Linq;

namespace Poryecto_Final.Models.Airbnb
{
    public class AirbnbMapper
    {
        public static List<AirbnbTrack> AirbnbResponseToAirbnbTracks(AirbnbResponse response)
        {
            if (response == null || response.Results == null)
                return null;

            return response.Results.Select(result => new AirbnbTrack
            {
                ID = result.Id,
                name = result.Name,
                Url = result.Url,
                Bathrooms = result.Bathrooms,
                Bedrooms = result.Bedrooms,
                Images = result.Images,
                Address = result.Address,
                Rate = result.Rating.HasValue ? (long)(result.Rating * 100) : 0, 
                Title = result.Type,
                Amount = result.Price?.Total ?? 0
            }).ToList();
        }
    }
}
