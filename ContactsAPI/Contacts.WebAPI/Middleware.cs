using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.WebAPI
{
    public class MyMiddleware
    {
        private RequestDelegate _nextDelegate;

        public MyMiddleware(RequestDelegate nextDelegate)
        {
            _nextDelegate = nextDelegate;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            await _nextDelegate.Invoke(httpContext);

        }
    }
}
