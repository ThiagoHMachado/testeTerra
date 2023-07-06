using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeTerra.Domain.DTO.Request;
using testeTerra.Domain.DTO.Response;

namespace testeTerra.ACL.Facade.Contract
{
    public interface IRepositoryFacade
    {
        Task<RepositoryResponse> CreateRepository(RepositoryRequest model, InfoGitRequest info);
    }
}
