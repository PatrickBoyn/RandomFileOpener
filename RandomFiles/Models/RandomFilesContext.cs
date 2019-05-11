using System.Data.Entity;

namespace RandomFiles.Models
{
    class RandomFilesContext : DbContext
    {
        public DbSet<RandomVideo> RandomVideos { get; set; }

        public RandomFilesContext() : base("name=DefaultConnection")
        {
            
        }
    }
}
