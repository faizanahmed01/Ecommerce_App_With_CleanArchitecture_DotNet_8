using EcommerceApp.Domain.Interfaces;
using EcommerceApp.InfraStructure.Data;
using EcommerceApp.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApp.InfraStructure.Repositories
{
    public class GenericRepository<TEntity>(AppDbContext dbContext ) : IGeneric<TEntity> where TEntity : class
    {
        public async Task<int> AddAsync(TEntity entities)
        {
          dbContext.Set<TEntity>().Add(entities);
          return await dbContext.SaveChangesAsync();    
            
        }

        public async Task<int> DeleteAsync(Guid id)
        {
            var entities = await dbContext.Set<TEntity>().FindAsync(id)??
          
            
             throw new ItemNotFoundException($"item with{id} is not found");

             dbContext.Set<TEntity>().Remove(entities);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {

            return await dbContext.Set<TEntity>().AsNoTracking().ToListAsync();    
                
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            var result = await dbContext.Set<TEntity>().FindAsync(id);
            return result!;
        }

        public async Task<int> UpdateAsync(TEntity entities)
        {
            dbContext.Set<TEntity>().Update(entities);
            return await dbContext.SaveChangesAsync();  
        }

        Task<TEntity> IGeneric<TEntity>.AddAsync(TEntity entities)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IGeneric<TEntity>.DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IGeneric<TEntity>.UpdateAsync(TEntity entities)
        {
            throw new NotImplementedException();
        }
    }
}
