namespace Jukebox.Models
{
    public class SongOfTheDay
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int SongId { get; set; }

        public string Caption { get; set; }

        public DateTime PostedAt { get; set; }

        public SongOfTheDay()
        {
            if (Caption == null)
            {
                Caption = "";
            }
        }

        public User User { get; set; }
        public Song Song { get; set; }
        public ICollection<SongOfTheDayLike> SongOfTheDayLikes { get; set; }
        public ICollection<SongOfTheDayComment> SongOfTheDayComments { get; set; }
    }
}