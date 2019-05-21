using System;
using System.IO;
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
            
            //Ignore the warning.
            //This orders alphabetically.
            files.OrderBy(x => x);

            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            }

            Console.WriteLine("***************************************");
            Console.WriteLine($"Total number of videos: {files.Length}");
        }

        //For diagnostic purposes.
        public static void LogRandomMovie(string randomMovie)
        {
            Console.WriteLine(Path.GetFileNameWithoutExtension(randomMovie));
        }
    }
}
