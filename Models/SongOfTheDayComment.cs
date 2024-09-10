namespace Jukebox.Models
{
    public class SongOfTheDayComment
    {
        public int Id { get; set; }

        public int SongOfTheDayId { get; set; }

        public int UserId { get; set; }

        public string CommentText { get; set; }

        public DateTime CommentedAt { get; set; }

        public SongOfTheDayComment()
        {
            if (CommentText == null)
            {
                CommentText = "";
            }
        }

        public required SongOfTheDay SongOfTheDay { get; set; }
        public required User User { get; set; }
    }
}