namespace Jukebox.Models
{
    public class UserAlbum
    {
        public int Id {get; set;}

        public int UserId {get; set;}

        public int AlbumId {get; set;}

        public int Rating {get; set;}

        public DateTime LoggedAt {get; set;}
    }
}