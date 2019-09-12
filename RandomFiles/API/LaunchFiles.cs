using System;
using System.Diagnostics;

namespace RandomFiles.API
{
    class LaunchFiles
    {
        Random rand = new Random(2345);
        public void PlayMovies()
        {
            var getFiles = new GetRandomFiles(rand);

            string randomMovie = getFiles.GetRandomMovie();

            Process.Start(randomMovie);

            //LogFiles.LogRandomMovie(randomMovie);
        }
    }
}