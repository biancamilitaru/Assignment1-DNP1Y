using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
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
            int max = adults.Max(adult => adult.Id);
            adult.Id = (++max);
            adults.Add(adult);
            string adultsAsJson = JsonSerializer.Serialize(adult);
            string alladult = GetAdults()+ adultsAsJson;
            File.WriteAllText(adultsFile, alladult);
        }
    }
}