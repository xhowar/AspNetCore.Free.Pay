﻿using Free.Pay.Core.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Free.Pay.Wechatpay
{
    public class WechatPayMiddleware
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;
        
        public WechatPayMiddleware(RequestDelegate next, ILogger<WechatPayMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task Invoke(HttpContext context, IEndpointRouter router)
        {
            try
            {
                var endpoint = router.Find(context);
                if (endpoint != null)
                {
                    _logger.LogInformation("Invoking WechatPay endpoint: {endpointType} for {url}", endpoint.GetType().FullName, context.Request.Path.ToString());

                    var result =endpoint.Process(context);

                    if (result != null)
                    {
                        _logger.LogTrace("Invoking result: {type}", result.GetType().FullName);
                        await result.ExecuteAsync(context);
                    }
                    return;
                }else{
                     context.Response.StatusCode = StatusCodes.Status404NotFound;
                }

            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception: {exception}", ex.Message);
            }
        }
    }
}
