using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Repository.Base
{
    public interface IRepositoryQuery<T> where T : EntityBase 
    {
        Task<T> GetById(long id);

        Task<IEnumerable<T>> GetAll();

        Task<IEnumerable<T>> GetByFilter(Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    }
}
