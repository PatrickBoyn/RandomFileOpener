using System;

namespace RandomFiles.API
{
    public static class LogFiles
    {
        //For diagnostic purposes.
        public static void LogMovies()
        {
            var getMovies = new GetRandomFiles();
            string[] mp4s = getMovies.GetFiles();

            foreach (string mp4 in mp4s)
            {
                Console.WriteLine(mp4);
            }
        }

        //For diagnostic purposes.
        public static void LogRandomMovie(string randomMovie)
        {
            Console.WriteLine(randomMovie);
        }
    }
}
