using System.Diagnostics;

namespace RandomFiles.API
{
    class LaunchFiles 
    {
        public void PlayMovies()
        {
            var getMovies = new GetRandomFiles(@"C:\Users\dakil\Desktop\MiscFiles\Extras", "*.mp4");

            string randomMovie = getMovies.GetRandomMovie();

            Process.Start(randomMovie);
            getMovies.LogRandomMovie(randomMovie);
        }
    }
}
