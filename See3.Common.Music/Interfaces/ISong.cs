using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Music.Interfaces
{
    public interface ISong
    {
        string Title { get; set; }
        string Artist { get; set; }
        string Album { get; set; }
        string Duration { get; set; }
    }
}
