using System;
using System.IO;

namespace RandomFiles.API
{
    class GetRandomMovies
    {
        public string[] GetMp4s()
        {
            const string path = @"C:\Users\dakil\Desktop\MiscFiles\Extras\";
            string[] filePaths = Directory.GetFiles(path, "*.mp4");
            return filePaths;
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
