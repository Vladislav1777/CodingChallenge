using CodingChallenge.Servise.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodingChallenge.Servise
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServise(this IServiceCollection services)
        {           
            services.AddScoped<IBonusPointСalculator, BonusPointСalculator>();

            return services;
        }
    }
}
