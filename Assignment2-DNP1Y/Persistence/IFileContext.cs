using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace Assignment2_DNP1Y.Persistence
{
    public interface IFileContext
    {
        Task<IList<Adult>> GetAdultsAsync();

        Task<Adult> AddAdultAsync(Adult adult);
    }
}