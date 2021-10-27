using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Assignment1_DNP1Y.Data
{
    public class AdultServices : IAdultServices
    {
        private string uri = "https://localhost:5001";
        private readonly HttpClient httpClient;
        
        public AdultServices()
        {
            httpClient = new HttpClient();
        }
        public async Task<IList<Adult>> GetAdultsAsync()
        {
            HttpResponseMessage responseMessage = await httpClient.GetAsync(uri + "/Adult");

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            string result = await responseMessage.Content.ReadAsStringAsync();

            Console.WriteLine(result);
            
            List<Adult> adults = JsonSerializer.Deserialize<List<Adult>>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            return adults;
        }

        public Task AddAdultAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}