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
            return "Hello World!";
        }
    }
}
