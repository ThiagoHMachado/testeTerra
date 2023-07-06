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
    public class BranchsService : BaseService<BranchsResponse, BranchsRequest>, IBranchsService
    {
        public BranchsService()
        {

        }
        public async Task<List<BranchsResponse>> GetBranchs(InfoGitRequest model)
        {
            model.Url = $"repos/{model.User}/{model.Repos}/branches";
            var ret = await Get(model);
            return ret;
        }
    }
}
