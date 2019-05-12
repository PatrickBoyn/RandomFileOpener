using System.Diagnostics;

namespace RandomFiles.API
{
    class LaunchFiles 
    {
        public void PlayMovies()
        {
            var getFiles = new GetRandomFiles();

            string randomMovie = getFiles.GetRandomMovie();

            Process.Start(randomMovie);

            LogFiles.LogRandomMovie(randomMovie);
        }
    }
}
