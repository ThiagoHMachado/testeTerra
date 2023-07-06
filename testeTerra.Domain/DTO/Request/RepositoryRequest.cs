using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeTerra.Domain.DTO.Request
{
    public class RepositoryRequest
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("private")]
        public bool _Private { get; set; } = false;

        [JsonProperty("has_issues")]
        public bool Hasissues { get; set; } = true;

        [JsonProperty("has_projects")]
        public bool Hasprojects { get; set; } = true;

        [JsonProperty("has_wiki")]
        public bool Haswiki { get; set; } = true;

    }
}
