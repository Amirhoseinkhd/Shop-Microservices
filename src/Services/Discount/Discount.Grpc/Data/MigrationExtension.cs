using Microsoft.EntityFrameworkCore;

namespace Discount.Grpc.Data;

public static class MigrationExtension
{
    public static void UseMigrations(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
        using var context = scope.ServiceProvider.GetService<DiscountContext>();
        context?.Database.MigrateAsync();
    }
}