using Jukebox.Models;

namespace Jukebox.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        public Task<User> GetUserByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}