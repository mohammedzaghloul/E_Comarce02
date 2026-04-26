using Div.Link.E_Commerce.DAL.Data;
using Div.Link.E_Commerce.DAL.Models.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Repository.Base
{
    public class BaseRepository<T> :  IBaseRepository<T> where T : BaseEntity    
    {
        protected readonly ApplicationDbContext _dbContext;
        

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
