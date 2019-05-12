using System;
using System.IO;

namespace RandomFiles.API
{
    class GetRandomFiles
    {
        private readonly string _path;
        private readonly string _type;

        public GetRandomFiles(string path, string type)
        {
            _path = path;
            _type = type;
        }

        public string[] GetFiles()
        {
            string path = _path;
            string[] filePaths = Directory.GetFiles(_path, _type);
            return filePaths;
        }
        //For diagnostic purposes.
        public void LogMovies()
        {
            string[] mp4s = GetFiles();

            foreach (string mp4 in mp4s)
            {
                Console.WriteLine(mp4);
            }
        }

        //Gets a random movie from the list created above.
        public string GetRandomMovie()
        {
            var rand = new Random();
            string[] getMovieList = GetFiles();

            int length = getMovieList.Length;
            int randomIndex = rand.Next(0, length);
            string randomFile = getMovieList[randomIndex];

            return randomFile;
        }
        //For diagnostic purposes.
        public void LogRandomMovie(string randomMovie)
        {
            Console.WriteLine(randomMovie);
        }
    }
}
