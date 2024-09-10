using Jukebox.DTO;

namespace Jukebox.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository; 

        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<UserDTO> GetUserByIdAsync(int Id)
        {
            User user = await _userRepository.GetUserByIdAsync();
            return _mapper.Map<UserDto>(user)
        }
    }
}