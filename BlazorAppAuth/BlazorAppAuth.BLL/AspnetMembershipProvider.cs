using BlazorAppAuth.BLL.Interfaces;
using BlazorAppAuth.DAL.Interfaces;
using BlazorAppAuth.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreIdentitySample6.BLL
{
    public class AspnetMembershipProvider : IAspnetMembershipProvider
    {
        IAspnetMembershipRepository _Repo;
        public AspnetMembershipProvider(IAspnetMembershipRepository aspnetMembershipRepositoryRepo)
        {
            _Repo = aspnetMembershipRepositoryRepo;
        }
        public Task<OperationResult<AspnetMembershipDTO>> AddItemAsync(AspnetMembershipDTO item)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<IEnumerable<AspnetMembershipDTO>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<IEnumerable<AspnetMembershipDTO>>> GetAllAsync(int page, int limit)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<AspnetMembershipDTO>> GetByPrimaryKeyAsync(string value)
        {
            throw new NotImplementedException();
        }

        public async Task<OperationResult<IEnumerable<AspnetMembershipDTO>>> GetByPropertiesAsync(Dictionary<string, string> properties)
        {
            var result = new OperationResult<IEnumerable<AspnetMembershipDTO>>
            {
                Data = new List<AspnetMembershipDTO>()
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

        public Task<OperationResult<AspnetMembershipDTO>> RemoveItemAsync(string pkValue)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<AspnetMembershipDTO>> UpdateItemAsync(AspnetMembershipDTO toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
