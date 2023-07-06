using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeTerra.ACL.Gateways.Contract;
using testeTerra.Domain.DTO.Request;
using testeTerra.Domain.DTO.Response;
using testeTerra.GitHub.Contract;

namespace testeTerra.ACL.Gateways
{
    public class RepositoryGateway : IRepositoryGateway
    {
        private readonly IRepositoryService repositoryService;

        public RepositoryGateway(IRepositoryService repositoryService)
        {
            this.repositoryService = repositoryService;
        }
        public async Task<RepositoryResponse> CreateRepository(RepositoryRequest model, InfoGitRequest info)
        {
            return await repositoryService.CreateRepository(model, info);
        }
    }
}
