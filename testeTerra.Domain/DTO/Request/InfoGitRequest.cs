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
