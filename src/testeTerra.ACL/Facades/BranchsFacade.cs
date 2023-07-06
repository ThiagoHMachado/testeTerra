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
    public class BranchsFacade : IBranchsFacade
    {
        private readonly IBranchsGateway branchsService;

        public BranchsFacade(IBranchsGateway branchsService)
        {

            this.branchsService = branchsService;
        }

        public async Task<List<BranchsResponse>> GetBranchs(InfoGitRequest model)
        {
            return await branchsService.GetBranchs(model);
        }
    }
}
