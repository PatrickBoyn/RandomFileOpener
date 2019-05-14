using System.Collections.Generic;
using RandomFiles.Models;

namespace RandomFiles.Repository
{
    interface IRandomVideoRepository : IRepository<RandomVideo>
    {
        IEnumerable<RandomVideo> GetAllRandomVideos();
    }
}
