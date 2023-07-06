using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeTerra.Domain.DTO.Response;

namespace testeTerra.Domain.DTO.Request
{
    public class WebHookRequest
    {        
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("events")]
        public List<string> Events { get; set; }

        [JsonProperty("config")]
        public Config? Config { get; set; }
    }
    public class Config
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("insecure_ssl")]
        public string InsecureSsl { get; set; }
    }
}
