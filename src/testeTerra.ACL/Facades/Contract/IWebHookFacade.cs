﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeTerra.Domain.DTO.Request;
using testeTerra.Domain.DTO.Response;

namespace testeTerra.ACL.Facade.Contract
{
    public interface IWebHookFacade
    {
        Task<WebHookResponse> AddWebHook(WebHookRequest model, InfoGitRequest infod);
        Task<WebHookResponse> UpdateWebHook(WebHookRequestPatch model, InfoGitRequest info, long id);
        Task<List<WebHookResponse>> GetWebHook( InfoGitRequest info);
    }
}
