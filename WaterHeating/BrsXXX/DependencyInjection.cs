using Microsoft.Extensions.DependencyInjection;

namespace WaterHeating.BrsXXX;

public static class DependencyInjection
{
    public static void AddBrsXXX(this IServiceCollection services)
    {
        services.AddScoped<BrsXXX>(); // etc
    }
}