using AspNetCore.Proxy;
using AspNetCore.Proxy.Options;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace Proxy.Controllers
{ 
    public class ProxyController : Controller
    {
        [Route("proxy/{**rest}")]
        public Task Proxy(string rest)
        {
            var queryString = this.Request.QueryString.Value;
            HttpProxyOptions httpProxyOptions = HttpProxyOptionsBuilder.Instance
                .WithShouldAddForwardedHeaders(true)
                .WithBeforeSend((c, hrm) =>
                {
                    return Task.CompletedTask;
                })
                .Build();
            return this.HttpProxyAsync($"{rest}?{queryString}", httpProxyOptions);
        }
    }
}
