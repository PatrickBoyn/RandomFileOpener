using System;
using RandomFiles.API;

namespace RandomFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var getMovies = new GetRandomMovies();
            string getRandomMovie = getMovies.GetRandomMovie();

            Console.WriteLine(getRandomMovie);

            Console.ReadKey();
        }
    }
}
