using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Models;

namespace Assignment1_DNP1Y.Data
{
    public class AdultsJSONData : IAdultsData
    {
        private string adultsFile = "adults.json";
        private IList<Adult> adults;

        public AdultsJSONData()
        {
            if (!File.Exists(adultsFile))
            {
                string adultsAsJson = JsonSerializer.Serialize(adults);
                File.WriteAllText(adultsFile, adultsAsJson);
            }
            else
            {
                string content = File.ReadAllText(adultsFile);
                adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }
        }
        
        public IList<Adult> GetAdults()
        {
            List<Adult> temp = new List<Adult>(adults);
            return temp;
        }

        public void AddAdult(Adult adult)
        {
            adults.Add(adult);
            string adultsAsJson = JsonSerializer.Serialize(adult);
            File.WriteAllText(adultsFile, adultsAsJson);
        }
    }
}