using HackMD.API.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace HackMD.API;

public static class ServiceProvider
{
    public static IServiceCollection AddHackMarkdownApi(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<HackMarkdownOptions>(configuration.GetSection(HackMarkdownOptions.HackMarkdown));
        services.AddHttpClient<IHackMarkdownClient, HackMarkdownClient>((serviceProvider, config) =>
        {
            var option = serviceProvider.GetRequiredService<IOptions<HackMarkdownOptions>>().Value;
            config.BaseAddress = option.BaseUrl;
            config.DefaultRequestHeaders.Add("Authorization", $"Bearer {option.Token}");
        });
        return services;
    }
}
