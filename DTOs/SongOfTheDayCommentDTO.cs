namespace Jukebox.DTO
{
    public class SongOfTheDayComment
    {
        public int Id { get; set; }

        public int SongOfTheDayId { get; set; }

        public int UserId { get; set; }

        public string Comment { get; set; }

        public DateTime CommentedAt { get; set; }

        public SongOfTheDayComment()
        {
            if (Comment == null)
            {
                Comment = "";
            }
        }
    }
}