using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using See3.Common.Music.Interfaces;

namespace See3.Common.Music
{
    public class Artist
    {
       public string Name { get; set; }
       public List<Album> Albums { get; set; }
       public List<Song> Songs { get; set; }

        public string ImageUri { get; set; }

        public Artist()
        {
            Songs = new List<Song>();
            Albums = new List<Album>();
        }
    }
}
