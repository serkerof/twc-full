using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Net;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;

namespace Core.Extensions
{
    public class ExceptionMiddlewareBase
    {
        private RequestDelegate _next;

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(httpContext, e);
            }
        }

        private Task HandleExceptionAsync(HttpContext httpContext, Exception e)
        {
            throw new NotImplementedException();
        }
    }
}