namespace Jukebox.DTO
{
    public class UserDTO 
    {
        public int Id {get; set;}

        public string Username {get; set;}

        public string Email {get; set;}

        public string ProfilePicture {get; set;}

        public string Bio {get; set;}

        public DateTime CreatedAt{get; set;}

        public DateTime UpdatedAt {get; set;}

        public UserDTO()
        {
            if (Username == null)
            {
                Username = "";
            }

            if (Email == null)
            {
                Email = "";
            }

            if (ProfilePicture == null)
            {
                ProfilePicture = "";
            }

            if (Bio == null)
            {
                Bio = "";
            }
        }
    }
}