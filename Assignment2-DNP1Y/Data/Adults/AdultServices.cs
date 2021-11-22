using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_DNP1Y.DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Assignment1_DNP1Y.Data.Adults
{
    public class AdultServices : IAdultsServices
    {
        private AdultDbContext adultDbContext;
        
        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            using AdultDbContext adultDbContext = new AdultDbContext();
            EntityEntry<Adult> adultAdded = await adultDbContext.Adults.AddAsync(adult);
            await adultDbContext.SaveChangesAsync();
            return adultAdded.Entity;
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            using AdultDbContext adultDbContext = new AdultDbContext();
            return await adultDbContext.Adults.ToListAsync();
        }
    }
}