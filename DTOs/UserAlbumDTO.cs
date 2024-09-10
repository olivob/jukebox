namespace Jukebox.DTO
{
    public class UserAlbumDTO
    {
        public int Id {get; set;}

        public int UserId {get; set;}

        public int AlbumId {get; set;}

        public int Rating {get; set;}

        public DateTime LoggedAt {get; set;}
    }
}