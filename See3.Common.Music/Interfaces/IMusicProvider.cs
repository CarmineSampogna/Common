using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Music.Interfaces
{
    public interface IMusicProvider
    {
        Task<IEnumerable<IArtist>> GetArtistsForUserAsync(string userId);
        Task<IEnumerable<IAlbum>> GetAlbumsForUserAsync(string userId);
        Task<IEnumerable<ISong>> GetSongsForUserAsync(string userId);
    }
}
