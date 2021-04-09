using LoginService.Models;

namespace LoginService.Repository
{
    public interface IUserRepository
    {
         int createUser(User user);
         bool LoginValidate(string userName, string password);
    }
}