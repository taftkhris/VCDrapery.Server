using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace VCDrapery.Server
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _requestDelegate;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate requestDelegate, ILogger<ExceptionMiddleware> logger)
        {
            this._requestDelegate = requestDelegate;
            this._logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await this._requestDelegate(httpContext);
            }
            catch (ArgumentException cause)
            {
                await this.HandleExceptionAsync(httpContext, StatusCodes.Status400BadRequest, cause.Message);
            }
            catch (Exception cause)
            {
                this._logger.LogError(cause, "Internal server error.");
                await this.HandleExceptionAsync(httpContext, StatusCodes.Status500InternalServerError, cause.Message);
            }
        }

        private Task HandleExceptionAsync(HttpContext httpContext, int statusCode, string message)
        {
            httpContext.Response.StatusCode = statusCode;
            return httpContext.Response.WriteAsync(message);
        }
    }
}
