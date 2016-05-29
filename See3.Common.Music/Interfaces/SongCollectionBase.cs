using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Music.Interfaces
{
    public abstract class SongCollectionBase : IMediaContainer
    {
        public List<Song> Songs { get; set; }
        public IEnumerable<Uri> MediaUris
        {
            get
            {
                try
                {
                    if (Songs == null) return null;
                    return Songs.Select(s => new Uri(s.Uri, UriKind.RelativeOrAbsolute));
                }
                catch (Exception ex)
                {
                    throw new Exception("Something broke", ex);
                }
            }
            set
            {
                return;
            }
        }
        public SongCollectionBase()
        {
            try
            {
                Songs = new List<Song>();
            }
            catch (Exception ex)
            {
                throw new Exception("Something broke", ex);
            }
        }
    }
}
