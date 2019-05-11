using System.Diagnostics;

namespace RandomFiles.API
{
    class LaunchFiles : GetRandomMovies
    {
        public void PlayMovies()
        {
            string randomMovie = GetRandomMovie();

            Process.Start(randomMovie);
            LogRandomMovie(randomMovie);
        }
    }
}
