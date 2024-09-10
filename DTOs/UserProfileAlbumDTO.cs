namespace Jukebox.DTO
{
    public class UserProfileAlbumDTO
    {
        public int Id {get; set;}

        public int UserId {get; set;}

        public int AlbumId {get; set;}

        public int? Rank {get; set;}
    }
}