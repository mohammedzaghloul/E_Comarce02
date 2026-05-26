using MZ.Dev.Domain.Entityes;
using MZ.Dev.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZ.Dev.Domain.Repositores
{
    public interface IGenericRepository<T>  where T:ModelBase
    {
        public Task<IReadOnlyList<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> specification);
        Task<T> GetByIdWithSpecAsync(ISpecification<T> specification);
    }
}
