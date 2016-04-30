using System;
using System.Collections.Generic;

namespace See3.Common.Music.Interfaces
{
    public interface IAlbum<TSong>
    {
        string Title { get; set; }
        DateTimeOffset ReleaseDate { get; set; }
        string Artist { get; set; }
        IEnumerable<TSong>  Songs { get; set; }
    }
}