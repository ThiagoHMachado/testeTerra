﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeTerra.Domain.DTO.Response
{
    public class WebHookResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("events")]
        public List<string> Events { get; set; }

        [JsonProperty("config")]
        public Config Config { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("test_url")]
        public string TestUrl { get; set; }

        [JsonProperty("ping_url")]
        public string PingUrl { get; set; }

        [JsonProperty("deliveries_url")]
        public string DeliveriesUrl { get; set; }

        [JsonProperty("last_response")]
        public LastResponse LastResponse { get; set; }
    }
    public class Config
    {
        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("insecure_ssl")]
        public string InsecureSsl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class LastResponse
    {
        [JsonProperty("code")]
        public object Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public object Message { get; set; }
    }
}
