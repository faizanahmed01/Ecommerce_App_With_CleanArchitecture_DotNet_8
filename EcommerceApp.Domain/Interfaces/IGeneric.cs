using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Domain.Interfaces
{
    public interface IGeneric<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(Guid id);

        Task<TEntity> AddAsync(TEntity entities);
        Task<TEntity> UpdateAsync(TEntity entities);    
        Task<TEntity> DeleteAsync(Guid id);

    }
}
