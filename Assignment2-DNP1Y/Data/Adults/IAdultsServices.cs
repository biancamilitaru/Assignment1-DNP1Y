using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace Assignment1_DNP1Y.Data.Adults
{
    public interface IAdultsServices
    {
        Task<Adult> AddAdultAsync(Adult adult);
        Task<IList<Adult>> GetAdultsAsync();
    }
}