using System.Threading.Tasks;
using Entities;

namespace Assignment1_DNP1Y.Data
{
    public interface IUserInterface
    {

        Task<User> GetUserAsync(string username);
    }
}