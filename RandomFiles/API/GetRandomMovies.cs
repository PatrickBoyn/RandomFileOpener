using System;
using System.IO;

namespace RandomFiles.API
{
    class GetRandomMovies
    {

        //Ignore the comment about the name.
        public string[] GetMp4s()
        {
            const string path = @"C:\Users\dakil\Desktop\MiscFiles\Extras\";
            string[] filePaths = Directory.GetFiles(path, "*.mp4");
            return filePaths;
        }

        public void LogMovies()
        {
            string[] mp4s = GetMp4s();

            foreach (string mp4 in mp4s)
            {
                Console.WriteLine(mp4);
            }
        }

        //Gets a random movie from the list created above.
        public string GetRandomMovie()
        {
            var rand = new Random();
            string[] getMovieList = GetMp4s();

            int length = getMovieList.Length;
            int randomIndex = rand.Next(0, length);
            string randomFile = getMovieList[randomIndex];

            return randomFile;
        }
    }
}
