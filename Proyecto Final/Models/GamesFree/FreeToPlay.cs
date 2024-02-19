using Newtonsoft.Json;
using ProyectoFinal.models.FreeToPLay;

namespace Poryecto_Final.Models.Freetoplay
{
    public class FreeToPlay
    {
            public long Id { get; set; }
            public string Title { get; set; }
            public Uri Thumbnail { get; set; }
            public string ShortDescription { get; set; }
            public Uri GameUrl { get; set; }
        public string Genre { get; set; }
        public Platform Platform { get; set; }
            public string Publisher { get; set; }
            public string Developer { get; set; }
            public string ReleaseDate { get; set; }
            public Uri FreetogameProfileUrl { get; set; }
        }

    public enum Genre { BattleRoyale, Fighting, Mmo, Mmorpg, Moba, Shooter, Strategy };
    public enum Platform { PcWindows, PcWindowsWebBrowser, WebBrowser }

    
}
