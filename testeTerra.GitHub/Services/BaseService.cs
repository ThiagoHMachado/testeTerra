using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using testeTerra.Domain.DTO.Request;

namespace testeTerra.GitHub.Services
{
    public abstract class BaseService<Response, Request> where Response : class
                                                        where Request : class
    {
        public static string BaseUrl = "https://api.github.com/";

        private static HttpClient Client;

        private void ConfigHeaderHttpClient(string token)
        {
            Client = new HttpClient();         
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Client.DefaultRequestHeaders.Add("Authorization", $"token {token}");
            Client.DefaultRequestHeaders.Connection.Add("keep-alive");            
            Client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
            //Client.DefaultRequestHeaders.Add("Content-Type", $"application/json");
        }

        public async Task<Response> Post(Request content, InfoGitRequest info)
        {
            var url = $"{BaseUrl}{info.Url}";
            ConfigHeaderHttpClient(info.Token);
           // JsonContent data = JsonContent.Create(content);
            var json = JsonConvert.SerializeObject(content);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, stringContent);
          
            if (response.IsSuccessStatusCode)
            {
                var ret = response.Content.ReadAsStringAsync().Result;
                var rere = JsonConvert.DeserializeObject<Response>(ret);
                return rere;
            }
            var errMsg = response.Content.ReadAsStringAsync().Result;
            
            throw new Exception(errMsg);
        }
        public async Task<Response> Patch(WebHookRequestPatch content, InfoGitRequest info)
        {
            var url = $"{BaseUrl}{info.Url}";
            ConfigHeaderHttpClient(info.Token);
            var json = JsonConvert.SerializeObject(content);
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            var response = await Client.PatchAsync(url, stringContent);
            if (response.IsSuccessStatusCode)
            {
                var ret = response.Content.ReadAsStringAsync().Result;
                var rere = JsonConvert.DeserializeObject<Response>(ret);
                return rere;
            }
            var errMsg = response.Content.ReadAsStringAsync().Result;
            throw new Exception(errMsg);
        }
        public async Task<List<Response>> Get(InfoGitRequest info)
        {
            ConfigHeaderHttpClient(info.Token);      
            var url = $"{BaseUrl}{info.Url}";
            var response = await Client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var ret = response.Content.ReadAsStringAsync().Result;
                var rere = JsonConvert.DeserializeObject<List<Response>>(ret);
                return rere;
            }            
            var errMsg = response.Content.ReadAsStringAsync().Result;
            throw new Exception(errMsg);
        }
    }

  
}

