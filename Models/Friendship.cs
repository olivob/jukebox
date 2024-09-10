namespace Jukebox.Models
{
    public class Friendship
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int FriendId { get; set; }

        public DateTime CreatedAt { get; set; }

        public required User User { get; set; }
        public required User Friend { get; set; }

    }
}