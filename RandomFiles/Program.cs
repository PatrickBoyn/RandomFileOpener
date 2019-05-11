using System;
using RandomFiles.API;

namespace RandomFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileLauncher = new LaunchFiles();

            fileLauncher.PlayMovies();

            Console.ReadKey();
        }
    }
}
