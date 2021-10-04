using System.Collections.Generic;
using Models;

namespace Assignment1_DNP1Y.Data
{
    public interface IAdultsData
    {
        IList<Adult> GetAdults();
        void AddAdult(Adult adult);
    }
}