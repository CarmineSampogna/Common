using System.Collections.Generic;

namespace See3.Common.Music.Interfaces
{
    public interface IArtist : IMusicItem
    {
        string Bio { get; set; }
        IEnumerable<IAlbum> Albums { get; set; }
        IEnumerable<ISong> Songs { get; set; }
    }
}