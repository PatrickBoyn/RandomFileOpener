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

        //Ignore the comment about the name.
        public string[] GetFiles()
        {
            string path = _path;
            string[] filePaths = Directory.GetFiles(path, _type);
            return filePaths;
        }
        //For diagnostic purposes.
        public void LogMovies()
        {
            var getMovies = new GetRandomFiles(@"C:\Users\dakil\Desktop\MiscFiles\Extras\", "*.mp4");

            string[] mp4s = getMovies.GetFiles();

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
