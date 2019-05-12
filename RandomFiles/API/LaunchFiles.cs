using System.Diagnostics;

namespace RandomFiles.API
{
    class LaunchFiles 
    {
        public void PlayMovies()
        {
            var getMovies = new GetRandomMovies();

            string randomMovie = getMovies.GetRandomMovie();

            Process.Start(randomMovie);
            getMovies.LogRandomMovie(randomMovie);
        }
    }
}
