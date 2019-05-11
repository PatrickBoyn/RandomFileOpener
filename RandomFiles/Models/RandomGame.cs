using System;

namespace RandomFiles.Models
{
    class RandomGame
    {
        public int Id { get; set; }
        public string FullUrl { get; set; }
        public string VideoName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastAccessed { get; set; }
    }
}
