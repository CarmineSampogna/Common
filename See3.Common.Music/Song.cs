using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using See3.Common.Music.Interfaces;

namespace See3.Common.Music
{
    public class Song : IMediaContainer
    {
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public Album Album { get; set; }
        public TimeSpan Duration { get; set; }
        public string Uri { get; set; }
        public int PlayCount { get; set; }

        public IEnumerable<Uri> MediaUris
        {
            get
            {
                return new[] { new Uri(Uri, UriKind.RelativeOrAbsolute) };
            }
            set { return; }
        }
    }
}
