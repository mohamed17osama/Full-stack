namespace Assignment_4.Middleware
{
    public class SunSet
    {
        private readonly RequestDelegate _next;

        public SunSet(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/api/v1"))
            {
                context.Response.Headers.Append("sunset", "sat 01 sept 2026");
            }

            await _next(context);


        }
    }
}
