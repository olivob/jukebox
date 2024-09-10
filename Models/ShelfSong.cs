namespace Jukebox.Models
{
    public class ShelfSong
    {
        public int Id { get; set; }

        public int ShelfId { get; set; }

        public int SongId { get; set; }

        public int Order { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public required Shelf Shelf { get; set; }

        public required Song Song { get; set; }
    }
}