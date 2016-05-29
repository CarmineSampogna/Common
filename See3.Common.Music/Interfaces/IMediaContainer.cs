using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Music.Interfaces
{
    public interface IMediaContainer
    {
        IEnumerable<Uri> MediaUris { get; set; }
    }
}
