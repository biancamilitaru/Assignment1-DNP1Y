using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Assignment1_DNP1Y.Data
{
    public interface IAdultServices
    {
        Task<IList<Adult>> GetAdultsAsync();
        Task AddAdultAsync(Adult adultToAdd);
    }
}