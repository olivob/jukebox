using Jukebox.DTO;

namespace Jukebox.Services.UserServices
{
    public interface IUserService
    {
        Task<UserDTO> GetUserByIdAsync(int Id);
    }
}