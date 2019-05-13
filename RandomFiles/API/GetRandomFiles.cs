using System;
using System.IO;

namespace RandomFiles.API
{
    class GetRandomFiles
    {
        private readonly string _path;
        private readonly string _type;
        
        public GetRandomFiles(string path= @"C:\Users\dakil\Desktop\Extras", string type="*.mp4")
        {
            _path = path;
            _type = type;
        }

        public string[] GetFiles()
        {
            string test =Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = _path;
            string[] filePaths = Directory.GetFiles(_path, _type);
            return filePaths;
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
    }
}
