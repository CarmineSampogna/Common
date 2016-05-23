using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using See3.Common.Music.Interfaces;

namespace See3.Common.Music
{
    public abstract class DefaultMusicProvider
    {

        public abstract Task<IEnumerable<Album>> GetAlbumsAsync();

        public abstract Task<IEnumerable<Artist>> GetArtistsAsync();

        public abstract Task<IEnumerable<Song>> GetSongsAsync();
    }
}
