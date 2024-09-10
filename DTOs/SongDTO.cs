namespace Jukebox.Models
{
    public class SongDTO
    {
        public int Id {get; set;}

        public int AlbumId {get; set;}

        public string Title {get; set;}
        
        public TimeSpan Duration {get; set;}

        public int TrackNumber {get; set;}

        public DateTime CreatedAt {get; set;}

        public DateTime UpdatedAt {get; set;}

        public SongDTO()
        {
            if (Title == null)
            {
                Title = "";
            }
        }
    }
}