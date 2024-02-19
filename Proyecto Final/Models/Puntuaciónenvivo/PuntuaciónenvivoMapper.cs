using Proyecto_Final.Models.Puntuaciónenvivo;
using System.Collections.Generic;

namespace Proyecto_Final.Models.Puntuaciónenvivo
{
    public class PuntuaciónenvivoMapper
    {
        public static List<PuntuaciónenvivoTrack> PuntuaciónenvivosResponseToPuntuaciónenvivosTracks(PuntuaciónenvivoTrackResponse response)
        {
            List<PuntuaciónenvivoTrack> result = new List<PuntuaciónenvivoTrack>();

            foreach (var stage in response.Stages)
            {
                foreach (var eventItem in stage.Events)
                {
                    PuntuaciónenvivoTrack track = new PuntuaciónenvivoTrack
                    {
                        Id = eventItem.Eid.ToString(),
                        NewsTag = eventItem.T1?[0]?.Nm ?? "",  
                        badgeUrl = stage.BadgeUrl ?? "",
                        firstColor = stage.FirstColor ?? "",

                        

                        
                        Events = new Event
                        {
                            Eid = eventItem.Eid,
                            
                        }.ToString()  
                    };

                   
                    result.Add(track);
                }
            }

            return result;
        }
    }

   
}
