using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Music.Interfaces
{
    public interface ISong : IMusicItem
    {
        IArtist Artist { get; set; }
        IAlbum Album { get; set; }
        TimeSpan Duration { get; set; }
    }
}
