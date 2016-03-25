using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Models.Interfaces
{
    /// <summary>
    /// A locatable entity with contact information.
    /// </summary>
    public interface IContactableEntity : ILocatableEntity
    {
        ContactInfo ContactInfo { get; set; }
    }
}
