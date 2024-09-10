using Jukebox.Models;

namespace Jukebox.Repositories.UserRepo
{
    public class UserRepository : IUserRepository
    {

        // need constructor with application db context 
        public Task<User> GetUserByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}