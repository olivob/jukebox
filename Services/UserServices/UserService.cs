// using AutoMapper;
// using Jukebox.DTO;
// using Jukebox.Models;
// using Jukebox.Repositories.UserRepo;

// namespace Jukebox.Services.UserServices
// {
//     public class UserService : IUserService
//     {
//         private readonly IUserRepository _userRepository;

//         private readonly IMapper _mapper;
//         public UserService(IUserRepository userRepository, IMapper mapper)
//         {
//             _userRepository = userRepository;
//             _mapper = mapper;
//         }
//         public async Task<UserDTO> GetUserByIdAsync(int id)
//         {
//             User user = await _userRepository.GetUserByIdAsync(id);
//             return _mapper.Map<UserDto>(user);
//         }
//     }
// }