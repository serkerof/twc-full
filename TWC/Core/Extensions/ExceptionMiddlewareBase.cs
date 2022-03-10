using Microsoft.AspNetCore.Http;

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
    }
}