using UserRegistrationMVC.Models;
using UserRegistrationMVC.Reposetory;

namespace UserRegistrationMVC.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public List<UserModel> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public bool RegisterUser(UserModel user)
        {
            return _userRepository.RegisterUser(user);
        }
    }
}
