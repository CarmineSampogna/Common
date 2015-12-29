using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Models.Interfaces
{
    public interface IAddress : IEntity
    {
        double Lat { get; set; }
        double Lon { get; set; }
        string Street1 { get; set; }
        string Street2 { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Country { get; set; }
        string StateAbbreviation { get; set; }
        string PostalCode { get; set; }
        string PhoneNumber { get; set; }
    }
}
