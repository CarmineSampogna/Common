using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using See3.Common.Music.Interfaces;

namespace See3.Common.Music
{
    public class Genre : SongCollectionBase
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
        public List<Artist> Artists { get; set; }
    }
}
