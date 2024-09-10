using Jukebox.DTO;

namespace Jukebox.Services.User
{
    public interface IUserService
    {
        Task<UserDTO> GetUserByIdAsync(int Id);
    }
}