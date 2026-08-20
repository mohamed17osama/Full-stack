using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_3.Exceptions
{
    public class GlobalException
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalException> _logger;

        public GlobalException(RequestDelegate next, ILogger<GlobalException> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                Console.WriteLine("middleware");
                await _next(context);
            }
            catch (NotFoundException ex)
            {
                await WriteProblemDetails(context, 404, "Not found exception", ex.Message);
            }
            catch (ConflictException ex)
            {
                await WriteProblemDetails(context, 409, "Conflict exception", ex.Message);
            }
            catch (Exception ex)
            {
                await WriteProblemDetails(context, 500, "Unhandled exception", ex.Message);
            }
           
        }
        public async Task WriteProblemDetails(HttpContext context, int status, string title, string detail)
        {
            context.Response.StatusCode = status;
            context.Response.ContentType = "application/problem+json";
            var problem = new ProblemDetails
            {
                Status = status,
                Title = title,
                Detail = detail
            };
            await context.Response.WriteAsJsonAsync(problem);
        }
    }
}
