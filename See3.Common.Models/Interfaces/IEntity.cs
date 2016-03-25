using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Models.Interfaces
{
    /// <summary>
    /// Base class for any model object that could be stored in a database.
    /// </summary>
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
