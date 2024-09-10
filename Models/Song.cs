namespace Jukebox.Models
{
    public class Song
    {
        public int Id { get; set; }

        public int AlbumId { get; set; }

        public string Title { get; set; }

        public TimeSpan Duration { get; set; }

        public int TrackNumber { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Song()
        {
            if (Title == null)
            {
                Title = "";
            }
        }

        public ICollection<UserFavoriteSong> UserFavoriteSongs { get; set; }
        public ICollection<SongOfTheDay> SongOfTheDays { get; set; }
        public ICollection<ShelfSong> ShelfSongs { get; set; }
    }
}