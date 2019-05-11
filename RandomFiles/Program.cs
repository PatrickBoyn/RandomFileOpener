using System;
using RandomFiles.API;

namespace RandomFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var getMovies = new GetRandomMovies();
            string[] listMovies = getMovies.GetMp4s();

            foreach (var movie in listMovies)
            {
                Console.WriteLine(movie);
            }

            Console.ReadKey();
        }
    }
}
