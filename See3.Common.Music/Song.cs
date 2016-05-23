using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using See3.Common.Music.Interfaces;

namespace See3.Common.Music
{
    public class Song
    {
       public string Title { get; set; }
       public Artist Artist { get; set; }
       public Album Album { get; set; }
       public string Duration { get; set; }
        public string Uri { get; set; }
    }
}
