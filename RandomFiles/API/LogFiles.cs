using System;

namespace RandomFiles.API
{
    public static class LogFiles
    {
        //For diagnostic purposes.
        public static void LogMovies()
        {
            var getFiles = new GetRandomFiles();
            string[] files = getFiles.GetFiles();

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }

        //For diagnostic purposes.
        public static void LogRandomMovie(string randomMovie)
        {
            Console.WriteLine(randomMovie);
        }
    }
}
