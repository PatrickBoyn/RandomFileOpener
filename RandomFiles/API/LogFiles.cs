using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RandomFiles.API
{
    public static class LogFiles
    {
        //For diagnostic purposes.
        public static void LogMovies()
        {
            var getFiles = new GetRandomFiles();
            string[] files = getFiles.GetFiles();
            
            //Ignore the warning.
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
