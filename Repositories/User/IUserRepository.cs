using Jukebox.Models;

namespace Jukebox.Repositories.User
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int Id);
    }
}