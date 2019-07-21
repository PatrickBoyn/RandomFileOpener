using System;

namespace RandomFiles.Repository
{
    interface IUnitOfWork : IDisposable
    {
        //IRandomVideosRepository RandomVideos { get; }

        int Save();
    }
}
