using System;
using Models;

namespace Assignment1_DNP1Y.Authentication
{
    public class UserService:IUserService

    {
        private string username;
        private string password;

        public UserService(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        
        public User ValidateUser(User user)
        {
            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (!user.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return user;
        }
    }
}
