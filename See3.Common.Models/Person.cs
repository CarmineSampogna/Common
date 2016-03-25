using See3.Common.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Models
{
    public class Person : IPerson
    {
        public Guid Id { get; set; }
        public string Name
        {
            get { return "/{FirstName} /{LastName}"; }
            set
            { }
        }

        public Guid AddressId { get; set; }
        public Guid ContactInfoId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public TimeSpan Age { get; set; }
        public string Description { get; set; }
        public virtual Address Address { get; set; }
        public virtual ContactInfo ContactInfo { get; set; }

        public Person()
        {
            Address = new Address();
            ContactInfo = new ContactInfo();
        }
    }
}
