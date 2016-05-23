using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Music.Interfaces
{
    public interface IMusicProvider
    {
        Task<IEnumerable<Artist>> GetArtistsAsync();
        Task<IEnumerable<Album>> GetAlbumsAsync();
        Task<IEnumerable<Song>> GetSongsAsync();
    }
}
