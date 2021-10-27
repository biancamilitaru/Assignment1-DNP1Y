using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Assignment1_DNP1Y.Authentication
{
    public class UserService : IUserService

    {
        private string uri = "https://localhoat:5003/User";
        private User user;

        public UserService()
        {
            using HttpClient httpClient = new HttpClient();
        }
        
        public async Task<User> ValidateUser(string username, string password)
        {
            User userToLogin = await GetUser(username);
            if (userToLogin == null)
            {
                throw new Exception("User not found");
            }

            if (!userToLogin.Password.Equals(user.Password))
            {
                throw new Exception("Incorrect password");
            }

            return userToLogin;
        }

        public async Task<User> GetUser(string username)
        {
            using HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.GetAsync(uri + $"/{username}");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            string result = await responseMessage.Content.ReadAsStringAsync();
            User userToLogin = JsonSerializer.Deserialize<User>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return userToLogin;
        }
    }
}
