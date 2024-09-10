namespace Jukebox.DTO
{
    public class SongOfTheDayLikeDTO
    {
        public int Id {get; set;}

        public int SongOfTheDayId {get; set;}

        public int UserId {get; set;}

        public DateTime LikedAt {get; set;}
    }
}