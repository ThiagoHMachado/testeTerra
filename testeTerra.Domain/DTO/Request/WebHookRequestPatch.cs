using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeTerra.Domain.DTO.Response;

namespace testeTerra.Domain.DTO.Request
{
    public class WebHookRequestPatch
    {       

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("events")]
        public List<string> Events { get; set; }


    }
   
}
