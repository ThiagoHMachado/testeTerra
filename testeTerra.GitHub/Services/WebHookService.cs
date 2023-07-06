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
    public class WebHookService : BaseService<WebHookResponse, WebHookRequest>, IWebHookService
    {
        public async Task<WebHookResponse> AddWebHook(WebHookRequest model, InfoGitRequest info)
        {
            info.Url = $"repos/{info.User}/{info.Repos}/hooks";
            var ret = await Post(model, info);
            return ret;
        }

        public async Task<List<WebHookResponse>> GetWebHook( InfoGitRequest info)
        {
            info.Url = $"repos/{info.User}/{info.Repos}/hooks";
            var ret = await Get(info);
            return ret;
        }

        public async Task<WebHookResponse> UpdateWebHook(WebHookRequestPatch model, InfoGitRequest info, long id)
        {
            info.Url = $"repos/{info.User}/{info.Repos}/hooks/{id}";
            var ret = await Patch(model, info);
            return ret;
        }
    }
}
