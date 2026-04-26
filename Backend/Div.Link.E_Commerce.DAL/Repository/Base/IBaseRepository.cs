using Div.Link.E_Commerce.DAL.Models.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Repository.Base
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        public Task< IReadOnlyList<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task<T> AddAsync(T entity);
        public Task DeleteByIdAsync(int id);
        public Task UpdateAsync(T entity);
        public Task DeleteAsync(T entity);
    }
}
