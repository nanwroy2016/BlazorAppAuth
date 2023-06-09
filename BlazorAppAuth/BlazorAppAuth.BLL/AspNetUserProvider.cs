using CoreIdentitySample6.BLL.Interfaces;
using CoreIdentitySample6.DAL.interfaces;
using CoreIdentitySample6.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreIdentitySample6.BLL
{
    public class AspNetUserProvider : IAspNetUserProvider
    {
        IAspNetUserRepository _Repo;
        public AspNetUserProvider(IAspNetUserRepository AspNetUserRepo)
        {
            _Repo = AspNetUserRepo;
        }
        public Task<OperationResult<AspNetUserDTO>> AddItemAsync(AspNetUserDTO item)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<IEnumerable<AspNetUserDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<IEnumerable<AspNetUserDTO>>> GetAllAsync(int page, int limit)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<AspNetUserDTO>> GetByPrimaryKeyAsync(string value)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult<IEnumerable<AspNetUserDTO>>> GetByPropertiesAsync(Dictionary<string, string> properties)
        {
            var result = new OperationResult<IEnumerable<AspNetUserDTO>>
            {
                Data = new List<AspNetUserDTO>()
            };
            try
            {
                result.Data = await _Repo.GetByPropertiesAsync(properties);
                result.IsSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = e.Message;
                result.IsSuccess = false;
            }
            return result;
        }

        public Task<OperationResult<AspNetUserDTO>> RemoveItemAsync(string pkValue)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<AspNetUserDTO>> UpdateItemAsync(AspNetUserDTO toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
