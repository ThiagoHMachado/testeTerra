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
    public class WebHookService : IWebHookService
    {
        private readonly IWebHookFacade webHookFacade;

        public WebHookService(IWebHookFacade webHookFacade)
        {
            this.webHookFacade = webHookFacade;
        }
        public async Task<WebHookResponse> AddWebHook(WebHookRequest model, InfoGitRequest info)
        {
            return await webHookFacade.AddWebHook(model, info);
        }

        public async Task<List<WebHookResponse>> GetWebHook( InfoGitRequest info)
        {
            return await webHookFacade.GetWebHook(info);
        }

        public async Task<WebHookResponse> UpdateWebHook(WebHookRequestPatch model, InfoGitRequest info, long id)
        {
            return await webHookFacade.UpdateWebHook(model, info, id);
        }
    }
}
