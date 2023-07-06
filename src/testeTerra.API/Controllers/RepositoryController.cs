using Microsoft.AspNetCore.Mvc;
using System.Net;
using testeTerra.Domain.DTO.Request;
using testeTerra.Service.Contract;

namespace testeTerra.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RepositoryController : Controller
    {
        private readonly ILogger<BranchsController> _logger;
        private readonly IRepositoryService service;

        public RepositoryController(ILogger<BranchsController> logger,
                               IRepositoryService service)
        {
            _logger = logger;
            this.service = service;
        }
        [HttpPost]
        [Route("repository")]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> PostRepository([FromBody]RepositoryRequest model)
        {
            try
            {
                var ret = await service.CreateRepository(model, new Domain.DTO.Request.InfoGitRequest());
                return Ok(ret);
            }           
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            

        }
    }
}
