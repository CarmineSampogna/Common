﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using See3.Common.Music.Interfaces;

namespace See3.Common.Music
{
    public class Artist : SongCollectionBase
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; }

        public string ImageUri { get; set; }


        public Artist() : base()
        {
            Albums = new List<Album>();
        }
    }
}
