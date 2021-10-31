using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Assignment1_DNP1Y.Data
{
    public class AdultServices : IAdultServices
    {
        private string uri = "https://localhost:5001/Adult";
        private readonly HttpClient httpClient;
        
        public AdultServices()
        {
            httpClient = new HttpClient();
        }
        public async Task<IList<Adult>> GetAdultsAsync()
        {
            HttpResponseMessage responseMessage = await httpClient.GetAsync(uri);

            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");

            string result = await responseMessage.Content.ReadAsStringAsync();

            List<Adult> adults = JsonSerializer.Deserialize<List<Adult>>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            return adults;
        }

        public async Task AddAdultAsync(Adult adultToAdd)
        {
            string adultAsJson = JsonSerializer.Serialize(adultToAdd);

            StringContent content = new StringContent(
                adultAsJson,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage responseMessage = await httpClient.PostAsync(uri, content);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }
    }
}