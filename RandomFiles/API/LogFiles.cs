using System;
using System.Linq;

namespace RandomFiles.API
{
    public static class LogFiles
    {
        //For diagnostic purposes.
        public static void LogMovies()
        {
            var getFiles = new GetRandomFiles();
            string[] files = getFiles.GetFiles();

            files.OrderBy(x => x);

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
