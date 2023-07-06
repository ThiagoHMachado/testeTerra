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
    public class WebHookFacade : IWebHookFacade
    {
        private readonly IWebHookGateway webHookService;

        public WebHookFacade(IWebHookGateway webHookService)
        {
            this.webHookService = webHookService;
        }
        public Task<WebHookResponse> AddWebHook(WebHookRequest model, InfoGitRequest info)
        {
            return webHookService.AddWebHook(model, info);
        }

        public Task<List<WebHookResponse>> GetWebHook( InfoGitRequest info)
        {
            return webHookService.GetWebHook(info);
        }

        public Task<WebHookResponse> UpdateWebHook(WebHookRequestPatch model, InfoGitRequest info, long id)
        {
            return webHookService.UpdateWebHook(model, info, id);
        }
    }
}
