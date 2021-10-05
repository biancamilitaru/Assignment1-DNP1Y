using Models;

namespace Assignment1_DNP1Y.Data
{
    public interface IUserInterface
    {
        User ValidateUser(string userName, string Password);
    }
}