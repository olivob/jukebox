namespace Jukebox.Models
{
    public class UserProfileAlbum
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int AlbumId { get; set; }

        public int? Rank { get; set; }


        public required User User { get; set; }
        public required Album Album { get; set; }
    }
}