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
            return this.HttpProxyAsync($"{endpoint}?{queryString}", httpProxyOptions);
        }
    }
}
