using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeTerra.ACL.Facade.Contract;
using testeTerra.Domain.DTO.Request;
using testeTerra.Domain.DTO.Response;
using testeTerra.Service.Contract;

namespace testeTerra.Service.Services
{
    public class RepositoryService : IRepositoryService
    {
        private readonly IRepositoryFacade repositoryFacade;

        public RepositoryService(IRepositoryFacade repositoryFacade)
        {
            this.repositoryFacade = repositoryFacade;
        }
        public async Task<RepositoryResponse> CreateRepository(RepositoryRequest model, InfoGitRequest info)
        {
            return await repositoryFacade.CreateRepository(model, info);
        }
    }
}
