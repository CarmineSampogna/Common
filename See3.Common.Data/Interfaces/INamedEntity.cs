using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Models.Interfaces
{
    public interface INamedEntity : IEntity
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}
