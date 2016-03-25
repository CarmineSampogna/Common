using See3.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Models
{
    public class Address : IAddress
    {
        public Guid Id { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string StateAbbreviation { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
