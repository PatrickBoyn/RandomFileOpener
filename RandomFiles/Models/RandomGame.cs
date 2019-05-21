using System;
using System.ComponentModel.DataAnnotations;

namespace RandomFiles.Models
{
    public class RandomGame
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string FullUrl { get; set; }
        [MaxLength(30)]
        public string GameName { get; set; }

        public string GameDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastAccessed { get; set; }
    }
}
