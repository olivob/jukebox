namespace Jukebox.DTO
{
    public class AlbumDTO
    {
        public int Id {get; set;}

        public string Title {get; set;}

        public string Artist {get; set;}

        public string CoverArtUrl {get; set;}

        public DateTime ReleaseDate {get; set;}

        public DateTime CreatedAt {get; set;}

        public DateTime UpdatedAt {get; set;}

        public AlbumDTO()
        {
            if (Title == null)
            {
                Title = "";
            }

            if (Artist == null)
            {
                Artist = "";
            }

            if (CoverArtUrl == null)
            {
                CoverArtUrl = "";
            }
        }
    }
}