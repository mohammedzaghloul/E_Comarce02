using MZ.Dev.Domain.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MZ.Dev.Domain.Specifications
{
    public interface ISpecification<T> where T:ModelBase
    {
        Expression<Func<T,bool>> Criteria { get; set; }
        List<Expression<Func<T, object>>> Includes {  get; set; }

        Expression<Func<T, object>> OrderBy { get; set; }
        Expression<Func<T, object>> OrderByDescending { get; set; }
    }
}
