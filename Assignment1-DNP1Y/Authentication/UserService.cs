using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Entities;

namespace Assignment1_DNP1Y.Authentication
{
    public class UserService : IUserService

    {
        private string uri = "https://localhost:5001/User";
        private readonly HttpClient httpClient;

        public UserService()
        {
            httpClient = new HttpClient();
        }
        
        public async Task<User> ValidateUser(string username, string password)
        {
            User userToLogin = await GetUser(username);
            
            if (userToLogin == null)
            {
                throw new Exception("User not found");
            }
            
            if (!userToLogin.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }
            
            return userToLogin;
        }

        public async Task<User> GetUser(string userName)
        {
            HttpResponseMessage responseMessage = await httpClient.GetAsync(uri + "/" + userName);
            
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
