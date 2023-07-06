using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeTerra.Domain.DTO.Request
{
    public class InfoGitRequest
    {
        public string User { get; set; } = "ThiagoHMachado";
        public string Repos { get; set; } = "testeTerra";
        public string Token { get; set; } = "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";
        public string Url { get; set; }
    }
}
