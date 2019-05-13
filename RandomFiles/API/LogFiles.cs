using System;
using System.Linq;
using System.Threading;

namespace RandomFiles.API
{
    public static class LogFiles
    {
        //For diagnostic purposes.
        public static void LogMovies()
        {
            Random rand = new Random();

            var getFiles = new GetRandomFiles(rand);
            string[] files = getFiles.GetFiles();
            
            //Ignore the warning.
            //This orders alphabetically.
            files.OrderBy(x => x);

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("***********************");
            Console.WriteLine($"Total number of videos: {files.Length}");
        }

        //For diagnostic purposes.
        public static void LogRandomMovie(string randomMovie)
        {
            Console.WriteLine(randomMovie);
        }
    }
}
