using UserRegistrationMVC.Models;

namespace UserRegistrationMVC.Reposetory
{
    public interface IUserRepository
    {
        bool RegisterUser(UserModel user);
        List<UserModel> GetAllUsers();
    }
}
