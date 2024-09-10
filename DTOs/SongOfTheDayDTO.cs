namespace Jukebox.DTO
{
    public class SongOfTheDayDTO
    {
        public int Id {get; set;}

        public int UserId {get; set;}

        public int SongId {get; set;}

        public string Caption {get; set;}

        public DateTime PostedAt {get; set;}

        public SongOfTheDayDTO()
        {
            if (Caption == null)
            {
                Caption = "";
            }
        }
    }
}