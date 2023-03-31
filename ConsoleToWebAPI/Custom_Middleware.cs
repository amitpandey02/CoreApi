using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConsoleToWebAPI
{
    public class Custom_Middleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            
          await context.Response.WriteAsync("Helloo from custom 1\n");
          await next(context);
          await context.Response.WriteAsync("Helloo from custom 2\n");
            
        }
    }
}
