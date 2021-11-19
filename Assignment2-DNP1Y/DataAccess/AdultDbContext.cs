using Microsoft.EntityFrameworkCore;
using Entities;

namespace Assignment2_DNP1Y.DataAccess
{
    public class AdultDbContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Adult> Adults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Adult.db");
        }

    }
    
}