using System.Threading.Tasks;
using Entities;

namespace Assignment1_DNP1Y.Authentication
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string password);
        Task<User> GetUser(string username);
    }
}