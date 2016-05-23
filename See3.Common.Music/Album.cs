using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using See3.Common.Music.Interfaces;

namespace See3.Common.Music
{
    public class Album
    {
       public string Title { get; set; }
       public DateTimeOffset ReleaseDate { get; set; }
       public Artist Artist { get; set; }
       public List<Song> Songs { get; set; }

        public string ImageUri { get; set; }

        public int ImageWeight { get; set; }

        public Album()
        {
            Songs = new List<Song>();
        }
    }
}
