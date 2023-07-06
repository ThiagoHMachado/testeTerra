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
    public class BranchsService : IBranchsService
    {
        private readonly IBranchsFacade branchsFacade;

        public BranchsService(IBranchsFacade branchsFacade)
        {
            this.branchsFacade = branchsFacade;
        }
        public async Task<List<BranchsResponse>> GetBranchs(InfoGitRequest model)
        {
            return await branchsFacade.GetBranchs(model);
        }
    }
}
