namespace Proyecto_Final.Models.Spotify
{
    public class SpotifyMapper
    {
        public static SpotifyTrack spotifyResponseToSpotifyTrack(SpotifyTrackResponse response)
        {
            SpotifyTrack result = new SpotifyTrack();
            result.Id = response.Id;
            result.Artist = response.Artists.Items.FirstOrDefault().Profile.Name;
            result.AlbumName = response.AlbumOfTrack.Name;
            result.AlbumCoverUrl = response.AlbumOfTrack.CoverArt.Sources.FirstOrDefault().Url.ToString();
            result.Title = response.Name;
            result.YoutubeURL = response.Youtube.Download.Where(d => d.Format.Contains("MPEG-4")).FirstOrDefault().Url.ToString();
            return result;
        }
    }
}
