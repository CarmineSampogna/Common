using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Models.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        TEntity InsertOrUpdate(TEntity entity);
        void Delete(Guid id);
        TEntity Get(Guid id);
        IEnumerable<TEntity> GetAll();
    }
}
