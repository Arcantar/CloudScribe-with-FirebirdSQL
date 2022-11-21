using cloudscribe.Logging;
using cloudscribe.Logging.EFCore;
using cloudscribe.Logging.EFCore.Common;
using cloudscribe.Logging.EFCore.FirebirdSQL;
using cloudscribe.Logging.Models;
using cloudscribe.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCloudscribeLoggingEFStorageFbSQL(
            this IServiceCollection services,
            string connectionString
            )
        {
            services //.AddEntityFrameworkFirebird()
                .AddDbContext<LoggingDbContext>((serviceProvider, options) =>
                {
                    options.UseFirebird(connectionString
                        , o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
                      //  );
                },
                optionsLifetime: ServiceLifetime.Singleton
                );

            services.TryAddScoped<IWebRequestInfoProvider, NoopWebRequestInfoProvider>();
            services.AddCloudscribeLoggingEFCommon();
            services.AddScoped<ILoggingDbContext, LoggingDbContext>();
            services.AddSingleton<ILoggingDbContextFactory, LoggingDbContextFactory>();
            services.AddScoped<ITruncateLog, Truncator>();
            services.AddScoped<IVersionProvider, VersionProvider>();

            return services;
        }
    }
}
