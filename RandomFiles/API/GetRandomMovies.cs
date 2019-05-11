using System;
using System.IO;

namespace RandomFiles.API
{
    class GetRandomMovies
    {
        public string[] GetMp4s()
        {
            string[] filePaths =
                Directory.GetFiles(@"C:\Users\dakil\Desktop\MiscFiles\ExtrasC:\Users\dakil\Desktop\MiscFiles\Extras",
                    "*.mp4");
            return filePaths;
        }
    }
}
