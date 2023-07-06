using Microsoft.AspNetCore.Mvc;
using System.Net;
using testeTerra.Service.Contract;

namespace testeTerra.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BranchsController : ControllerBase
    {

        private readonly ILogger<BranchsController> _logger;
        private readonly IBranchsService service;

        public BranchsController(ILogger<BranchsController> logger,
                               IBranchsService service)
        {
            _logger = logger;
            this.service = service;
        }

        [HttpGet]
        [Route("listbranchs")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetBranchs()
        {
            try
            {
                var ret = await service.GetBranchs(new Domain.DTO.Request.InfoGitRequest());
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}