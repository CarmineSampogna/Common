using System.Collections.Generic;

namespace See3.Common.Music.Interfaces
{
    public interface IArtist<TAlbum, TSong>
    {
        string Name { get; set; }
        IEnumerable<TAlbum> Albums { get; set; }
        IEnumerable<TSong> Songs { get; set; }
    }
}