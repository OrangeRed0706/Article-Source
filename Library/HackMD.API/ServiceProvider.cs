using HackMD.API.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace HackMD.API;

public static class ServiceProvider
{
    public static IServiceCollection AddHackMD(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<HackMDOptions>(configuration.GetSection(HackMDOptions.HackMD));
        services.AddHttpClient<IHackMDClient, HackMDClient>((serviceProvider, config) =>
        {
            var option = serviceProvider.GetRequiredService<IOptions<HackMDOptions>>().Value;
            config.BaseAddress = option.BaseUrl;
            config.DefaultRequestHeaders.Add("Authorization", $"Bearer {option.Token}");
        });
        return services;
    }
}
