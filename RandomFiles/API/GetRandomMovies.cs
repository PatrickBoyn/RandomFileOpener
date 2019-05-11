using System;
using System.IO;

namespace RandomFiles.API
{
    class GetRandomMovies
    {
        public string[] GetMp4s()
        {
            string path = @"C:\Users\dakil\Desktop\MiscFiles\Extras\";
            string[] filePaths = Directory.GetFiles(path, "*.mp4");
            return filePaths;
        }

        public string GetRandomMovie()
        {
            var rand = new Random();

            int length = GetMp4s().Length;
            int randomIndex = rand.Next(0, length);
            string randomFile = GetMp4s()[randomIndex];

            return randomFile;
        }
    }
}
