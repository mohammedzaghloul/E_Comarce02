using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using MZ.Dev.Domain.Entityes;
using MZ.Dev.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZ.Dev.Repository
{
    public static class SpecificationEvaluater<T> where T : ModelBase
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputquery,ISpecification<T> spec)
        {
            var query = inputquery;
            if (spec.Criteria != null)
            {
                query= query.Where(spec.Criteria);
            }
            if (spec.OrderBy != null)
            {
                query = query.OrderBy(spec.OrderBy);
            }
            else if (spec.OrderByDescending != null)
            {
                query = query.OrderByDescending(spec.OrderByDescending);
            }

            query = spec.Includes.Aggregate(query, (CurrentQuery, IncludeExpression) => CurrentQuery.Include(IncludeExpression));

      
            return query;
        }
    }
}
