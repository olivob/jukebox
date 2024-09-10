namespace Jukebox.DTO
{
    public class ShelfDTO
    {
        public int Id {get; set;}

        public int UserId {get; set;}

        public string Name {get; set;}

        public string CoverImageUrl {get; set;}

        public DateTime CreatedAt {get; set;}

        public DateTime UpdatedAt {get; set;}

        public ShelfDTO()
        {
            if (Name == null)
            {
                Name = "";
            }

            if (CoverImageUrl == null)
            {
                CoverImageUrl = "";
            }
        }
    }
}