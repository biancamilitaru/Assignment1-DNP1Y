using Models;

namespace Assignment1_DNP1Y.Authentication
{
    public interface IUserService
    {
        User ValidateUser(User user);
    }
}