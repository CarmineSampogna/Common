using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Models.Interfaces
{
    public interface IContactInfo : IEntity
    {
        string HomePhone { get; set; }
        string MobilePhone { get; set; }
        string EmailAddress { get; set; }
        string WebSiteUrl { get; set; }
        string FacebookUrl { get; set; }
        string TwitterUrl { get; set; }
        string InstagramUrl { get; set; }
        string LinkedInUrl { get; set; }
    }
}
