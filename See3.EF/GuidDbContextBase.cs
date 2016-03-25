using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.EF
{
    public abstract class GuidDbContextBase : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<Guid>()
           .Where(info => info.Name.ToLower() == "id")
           .Configure(configuration => configuration.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity));
            base.OnModelCreating(modelBuilder);
        }
    }
}
