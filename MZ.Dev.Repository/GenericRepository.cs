using Microsoft.EntityFrameworkCore;
using MZ.Dev.Domain.Entityes;
using MZ.Dev.Domain.Repositores;
using MZ.Dev.Domain.Specifications;
using MZ.Dev.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZ.Dev.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : ModelBase
    {
        private readonly StoreContext dbContext;

        public GenericRepository(StoreContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IReadOnlyList<T>> GetAllAsync() => await    dbContext.Set<T>().ToListAsync();

        public async Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> specification)
        {
            return await  ApplayingSpecification(specification).ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id) => await dbContext.Set<T>().FindAsync(id);

        public async Task<T> GetByIdWithSpecAsync(ISpecification<T> specification)
        {
            return await ApplayingSpecification(specification).FirstOrDefaultAsync();
        }
        private IQueryable<T> ApplayingSpecification(ISpecification<T> spec) 
        {

            return SpecificationEvaluater<T>.GetQuery(dbContext.Set<T>(), spec);
        }
    }
}
