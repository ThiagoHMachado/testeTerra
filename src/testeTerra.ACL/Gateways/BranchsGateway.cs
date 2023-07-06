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
    public class BranchsGateway : IBranchsGateway
    {
        private readonly IBranchsService branchsService;

        public BranchsGateway(IBranchsService branchsService)
        {

            this.branchsService = branchsService;
        }

        public async Task<List<BranchsResponse>> GetBranchs(InfoGitRequest model)
        {
            return await branchsService.GetBranchs(model);
        }
    }
}
