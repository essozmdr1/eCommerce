using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{   //imzaları atıyoruz.
    public interface IRepository<T > where T : BaseEntity
    {
         DbSet<T> Table { get; }
         IQueryable<T> GEtAll();
         IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate);
         Task<T> GetSingle(Expression<Func<T, bool>> predicate);
         Task<T> GetById(string id);
         Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> models);
        bool Delete(T model);
        bool DeleteRange(List<T> model);
        Task<bool> DeleteAsync(string id);
        bool Update (T model);
        Task<int> SaveAsync();
          

    }
}
