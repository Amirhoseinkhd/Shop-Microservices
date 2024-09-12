namespace Ordering.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddApiServices(this IServiceCollection services)
    {
        // Add Carter

        return services;
    }

    public static WebApplication UseApiServices(this WebApplication app)
    {
        // App.MapCarter
        return app;
    }
}