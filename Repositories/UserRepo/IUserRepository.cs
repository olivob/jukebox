using Jukebox.Models;

namespace Jukebox.Repositories.UserRepo
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int Id);
    }
}