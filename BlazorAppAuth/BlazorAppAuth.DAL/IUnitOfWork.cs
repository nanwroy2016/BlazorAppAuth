using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreIdentitySample6.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IQueryable<T> GetAll<T>() where T : class;
        IQueryable<T> GetWhere<T>(Expression<Func<T, bool>> func) where T : class;
        IQueryable<T> GetWhere<T>(Expression<Func<T, bool>> func, params Expression<Func<T, object>>[] joins) where T : class;
        IQueryable<T> GetWhere<T>(Expression<Func<T, bool>> func, List<string> joins) where T : class;

        T Add<T>(T toadd) where T : class;
        void Remove<T>(T toremove) where T : class;
        Task UpdateAsync<T>(T toupdate) where T : class;
        Task<int> SaveAsync();

        IKey GetPrimaryKey<T>() where T : class;
    }
}

