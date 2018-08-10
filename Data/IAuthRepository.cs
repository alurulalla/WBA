using System.Threading.Tasks;
using WBA.API.Dtos;
using WBA.API.Models;

namespace WBA.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string eamil, string password);
         Task<bool> UserExists(string username);
    }
}