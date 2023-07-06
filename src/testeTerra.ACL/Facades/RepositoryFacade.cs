using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeTerra.ACL.Facade.Contract;
using testeTerra.ACL.Gateways.Contract;
using testeTerra.Domain.DTO.Request;
using testeTerra.Domain.DTO.Response;


namespace testeTerra.ACL.Facade
{
    public class RepositoryFacade : IRepositoryFacade
    {
        private readonly IRepositoryGateway repositoryService;

        public RepositoryFacade(IRepositoryGateway repositoryService)
        {
            this.repositoryService = repositoryService;
        }
        public async Task<RepositoryResponse> CreateRepository(RepositoryRequest model, InfoGitRequest info)
        {
            return await repositoryService.CreateRepository(model, info);
        }
    }
}
