using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeTerra.Domain.DTO.Request;
using testeTerra.Domain.DTO.Response;
using testeTerra.GitHub.Contract;

namespace testeTerra.GitHub.Services
{
    public class RepositoryService : BaseService<RepositoryResponse, RepositoryRequest>, IRepositoryService
    {
        public async Task<RepositoryResponse> CreateRepository(RepositoryRequest model, InfoGitRequest info)
        {
            info.Url = $"user/repos";
            var ret = await Post(model, info);
            return ret;
        }
    }
}
