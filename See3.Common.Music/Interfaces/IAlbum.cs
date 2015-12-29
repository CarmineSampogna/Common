using System;
using System.Collections.Generic;

namespace See3.Common.Music.Interfaces
{
    public interface IAlbum : IMusicItem
    {
        DateTimeOffset ReleaseDate { get; set; }
        IArtist Artist { get; set; }
        IEnumerable<ISong>  Songs { get; set; }
    }
}