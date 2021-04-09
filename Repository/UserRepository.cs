using LoginService.Models;
using LoginService.EntityFrameworkCore;
using System.Linq;

namespace LoginService.Repository
{

    public class UserRepository : IUserRepository
    {
        ApplicationDBContext applicationDBContext;    
        public UserRepository(ApplicationDBContext _aapplicationDBContext)
        {
         applicationDBContext = _aapplicationDBContext; 
 
        }
        public int createUser(User user)
        {
            this.applicationDBContext.Add(user);
            this.applicationDBContext.SaveChanges();
            return 1;
        }

        public bool LoginValidate(string userName, string password)
        {
            var temp = this.applicationDBContext.users.Where(x => x.userName == userName && x.password == password).FirstOrDefault();
            if(temp == null)
            {
                return false;
            }
            else
            return true;
        }
    }
}