using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Models.Interfaces
{
    /// <summary>
    /// An entity with a name, description, and address.
    /// </summary>
    public interface ILocatableEntity : INamedEntity
    {
        Address Address { get; set; }
    }
}
