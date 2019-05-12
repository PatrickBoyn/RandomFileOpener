using System.Diagnostics;

namespace RandomFiles.API
{
    class LaunchFiles 
    {
        public void PlayMovies()
        {
            var getMovies = new GetRandomFiles();

            string randomMovie = getMovies.GetRandomMovie();

            Process.Start(randomMovie);

            LogFiles.LogRandomMovie(randomMovie);
        }
    }
}
