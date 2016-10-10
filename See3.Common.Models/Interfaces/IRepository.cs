using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See3.Common.Models.Interfaces
{
    public interface IRepository<TEntity, TKey> where TEntity : IEntity
    {
        Task<TEntity> InsertOrUpdateAsync(TEntity entity);
        Task DeleteAsync(TKey id);
        Task<TEntity> GetItemByIdAsync(TKey id);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
