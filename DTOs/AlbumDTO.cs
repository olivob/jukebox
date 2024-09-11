namespace Jukebox.DTO
{
    public class AlbumDTO
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Artist { get; set; }

        public string CoverArtUrl { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public AlbumDTO()
        {
            if (Name == null)
            {
                Name = "";
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