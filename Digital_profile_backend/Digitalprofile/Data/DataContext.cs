using Microsoft.EntityFrameworkCore;

namespace Digitalprofile.Data
{
    public class DataContext : DbContext  // we inerit from the EF 
    {
        public DataContext( DbContextOptions options):base(options)   // constructor on the datacontext bassing the the same to the base class
        {
        }

        public DbSet<Feedback> UserFeedback { get; set; }  //Table creation in database
    }
}
