using System;
using System.IO;

namespace RandomFiles.API
{
    class GetRandomFiles
    {
        private readonly Random _randomNumber;
        private readonly string _path;
        private readonly string _type;
        public GetRandomFiles(Random randomNumber = null, string path = @"C:\Users\dakil\Desktop\Extras", string type = "*.mp4")
        {
            _randomNumber = randomNumber;
            _path = path;
            _type = type;
        }

        public string[] GetFiles()
        {
            string path = _path;
            string[] filePaths = Directory.GetFiles(_path, _type);
            return filePaths;
        }

        //Gets a random movie from the list created above.
        public string GetRandomMovie()
        {
            string[] getMovieList = GetFiles();

            int length = getMovieList.Length;
            int randomIndex = _randomNumber.Next(0, length);
            string randomFile = getMovieList[randomIndex];

            return randomFile;
        }
    }
}