using Microsoft.AspNetCore.Http;

namespace AspNet.QrLogin.Middleware;

public class QrLoginMiddleware
{

    private readonly RequestDelegate _next;

    public QrLoginMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        await _next(httpContext);
    }
}
