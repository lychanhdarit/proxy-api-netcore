using AspNetCore.Proxy;
using AspNetCore.Proxy.Options;
using Microsoft.AspNetCore.Mvc;

namespace Proxy.Controllers
{ 
    public class ProxyController : Controller
    {
        [Route("proxy/{**endpoint}")]
        public Task Proxy(string endpoint)
        {
            var queryString = this.Request.QueryString.Value;
            HttpProxyOptions httpProxyOptions = HttpProxyOptionsBuilder.Instance
                .WithShouldAddForwardedHeaders(true)
                .WithBeforeSend((c, hrm) =>
                {
                    return Task.CompletedTask;
                })
                .Build();
            //endpoint: full url
            return this.HttpProxyAsync($"{endpoint}?{queryString}", httpProxyOptions);
        }
        [Route("proxy2/{**endpoint}")]
        public Task Proxy2(string endpoint)
        {
            var queryString = this.Request.QueryString.Value;
            HttpProxyOptions httpProxyOptions = HttpProxyOptionsBuilder.Instance
                .WithShouldAddForwardedHeaders(true)
                .WithBeforeSend((c, hrm) =>
                {
                    return Task.CompletedTask;
                })
                .Build();
            string host = "http://abc.com";//Custom  
            return this.HttpProxyAsync($"{host}/{endpoint}?{queryString}", httpProxyOptions);
        }
    }
}
