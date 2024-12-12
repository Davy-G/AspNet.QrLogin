using Microsoft.AspNetCore.Builder;

namespace AspNet.QrLogin.Extentions;

public static class QrLoginMiddlewareExtentions
{
    public static IApplicationBuilder UseQrLogin(this IApplicationBuilder app,string hubendpoint)
    {

        app.MapControllers();

        app.MapHub<QrLoginHub>(hubendpoint);

        return app;
    }

    // public static IServiceCollection AddQrLogin(this IServiceCollection services, Action<QrLoginOptions> configureOptions)
    // {
    //
    //     var options = new QrLoginOptions();
    //     configureOptions(options);
    //
    //     services.AddSingleton(options);
    //     services.AddSignalR();
    //     services.AddControllers();
    //
    //     return services;
    // }
}