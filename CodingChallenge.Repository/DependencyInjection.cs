using CodingChallenge.App.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CodingChallenge.Repository
{
    public static class DependencyInjection
    {        public static IServiceCollection AddRepository(this IServiceCollection services,
           IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];

            services.AddDbContext<CodingChallengeDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
            services.AddScoped<ICodingChallengeDbContext>(provider =>
                provider.GetService<CodingChallengeDbContext>());

            return services;
        }
    }
}
