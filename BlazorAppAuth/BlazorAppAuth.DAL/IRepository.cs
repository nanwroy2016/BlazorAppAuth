using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;


namespace BlazorAppAuth.DAL
{
    public interface IRepository<T_EF, T_DTO>
    {
        Task<IEnumerable<T_DTO>> GetAllAsync();
        Task<IEnumerable<T_DTO>> GetAllAsync(int page, int limit);
        Task<IEnumerable<T_DTO>> GetAllAsync<TKey>(int page, int records, Expression<Func<T_EF, TKey>> sortByFunc, OrderBy sortDirection = OrderBy.Ascending);
        Task<IEnumerable<T_DTO>> GetWhereAsync(Expression<Func<T_EF, bool>> func);
        Task<IEnumerable<T_DTO>> GetWhereAsync(Expression<Func<T_EF, bool>> func, int page, int amount);
        Task<IEnumerable<T_DTO>> GetWhereAsync(Expression<Func<T_EF, bool>> func, params Expression<Func<T_EF, object>>[] joins);
        Task<IEnumerable<T_DTO>> GetWhereAsync(Expression<Func<T_EF, bool>> func, List<string> joins);
        Task<IEnumerable<T_DTO>> GetWhereAsync<TKey>(Expression<Func<T_EF, bool>> func, int page, int records, Expression<Func<T_EF, TKey>> sortByFunc, OrderBy sortDirection = OrderBy.Ascending);
        Task<IEnumerable<T_DTO>> GetByPropertiesAsync(Dictionary<string, string> properties);
        Task<T_DTO> GetByPrimaryKeyAsync(string value);

        T_DTO Add(T_DTO toadd);
        void Remove(T_DTO toremove);
        Task UpdateAsync(T_DTO toupdate);
        Task<int> SaveAsync();

        IKey GetEntityPrimaryKey();
        string GetEntityPrimaryKeyName();
        string ReflectPrimaryKeyValue(T_DTO entity);
    }
}
