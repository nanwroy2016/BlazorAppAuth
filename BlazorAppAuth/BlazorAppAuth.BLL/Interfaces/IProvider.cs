using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreIdentitySample6.BLL.Interfaces
{
    public interface IProvider<T, Key> where T : class
    {
        Task<OperationResult<T>> GetByPrimaryKeyAsync(string value);
        Task<OperationResult<IEnumerable<T>>> GetByPropertiesAsync(Dictionary<string, string> properties);
        Task<OperationResult<IEnumerable<T>>> GetAllAsync();
        Task<OperationResult<IEnumerable<T>>> GetAllAsync(int page, int limit);
        Task<OperationResult<T>> AddItemAsync(T item);
        Task<OperationResult<T>> RemoveItemAsync(string pkValue);
        Task<OperationResult<T>> UpdateItemAsync(T toUpdate);
    }
}

