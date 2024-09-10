using System.ComponentModel.DataAnnotations;

namespace Jukebox.Models
{
    public class User 
    {
        [Key]
        public Guid Id {get; set;}

        [Required]
        public string Username {get; set;}

        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Email {get; set;}

        [Required]
        public string PasswordHash {get; set;}

        public string ProfilePicture {get; set;}

        public string Bio {get; set;}

        [Required]
        public DateTime CreatedAt {get; set;}

        [Required]
        public DateTime UpdatedAt {get; set;}

        // need to add attributes from other models pertaining to User 

        public User()
        {
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