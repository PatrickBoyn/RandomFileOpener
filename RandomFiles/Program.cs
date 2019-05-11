using System;
using RandomFiles.API;

namespace RandomFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var getMovies = new GetRandomMovies();

            getMovies.LogMovies();
            Console.WriteLine("*************************");
            getMovies.LogRandomMovie();

            Console.ReadKey();
        }
    }
}
