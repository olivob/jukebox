namespace Jukebox.Models
{
    public class SongOfTheDayLike
    {
        public int Id { get; set; }

        public int SongOfTheDayId { get; set; }

        public int UserId { get; set; }

        public DateTime LikedAt { get; set; }

        public required SongOfTheDay SongOfTheDay { get; set; }
        public required User User { get; set; }
    }
}