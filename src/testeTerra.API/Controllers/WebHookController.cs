using Microsoft.AspNetCore.Mvc;
using System.Net;
using testeTerra.Domain.DTO.Request;
using testeTerra.Service.Contract;

namespace testeTerra.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebHookController : Controller
    {
        private readonly IWebHookService service;

        public WebHookController(ILogger<BranchsController> logger,
                                IWebHookService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("listwebhooks")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetWebhooks()
        {
            try
            {
                var ret = await service.GetWebHook(new Domain.DTO.Request.InfoGitRequest());
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("webhooks")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> PostWebhooks([FromBody] WebHookRequest model)
        {
            try
            {
                var ret = await service.AddWebHook(model, new Domain.DTO.Request.InfoGitRequest());
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPatch]
        [Route("updatewebhooks/{id}")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> PatchWebhooks([FromBody] WebHookRequestPatch model,long id)
        {
            try
            {
                var ret = await service.UpdateWebHook(model, new Domain.DTO.Request.InfoGitRequest(),id);
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
