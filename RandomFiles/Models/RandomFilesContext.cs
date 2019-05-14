using System.Data.Entity;

namespace RandomFiles.Models
{
    public class RandomFilesContext : DbContext
    {
        public DbSet<RandomVideo> RandomVideos { get; set; }
        public DbSet<RandomGame> RandomGames { get; set; }
        public RandomFilesContext() : base("name=DefaultConnection")
        {
            
        }
    }
}
