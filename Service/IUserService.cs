using UserRegistrationMVC.Models;

namespace UserRegistrationMVC.Service
{
    public interface IUserService
    {
        bool RegisterUser(UserModel user);
        List<UserModel> GetAllUsers();
    }
}
