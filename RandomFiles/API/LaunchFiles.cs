using System.Diagnostics;

namespace RandomFiles.API
{
    class LaunchFiles
    {
        public void PlayMovies()
        {
            var getMovies = new GetRandomMovies();
            Process.Start(getMovies.GetRandomMovie());
        }
    }
}
