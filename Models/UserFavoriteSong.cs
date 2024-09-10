namespace Jukebox.Models
{
    public class UserFavoriteSong
    {
        public int Id { get; set; }

        public int UserAlbumId { get; set; }

        public int SongId { get; set; }

        public int Rank { get; set; }

        public required UserAlbum UserAlbum { get; set; }
        public required Song Song { get; set; }
    }
}