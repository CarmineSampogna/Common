using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Models.Interfaces
{
    public interface IPerson : IContactableEntity
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        TimeSpan Age { get; set; }
    }
}
