using cloudscribe.Core.Models;
using cloudscribe.Core.Storage.EFCore.Common;
using cloudscribe.Core.Storage.EFCore.FirebirdSQL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCloudscribeCoreEFStorageFbSql(
        this IServiceCollection services,
        string connectionString,
        bool useSingletonLifetime = false,
        int maxConnectionRetryCount = 0,
        int maxConnectionRetryDelaySeconds = 30,
        ICollection<int> transientSqlErrorNumbersToAdd = null //,
        //FbSqlDbContextOptionsBuilder fbSqlOptions = null

        )
    {
        services.AddCloudscribeCoreEFCommon(useSingletonLifetime);

        services//.AddEntityFrameworkFirebird()
            .AddDbContext<CoreDbContext>(options =>
                options.UseFirebird(connectionString, o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)),
                optionsLifetime: ServiceLifetime.Singleton
                );

        services.AddScoped<ICoreDbContext, CoreDbContext>();
        services.AddScoped<IDataPlatformInfo, DataPlatformInfo>();

        services.AddSingleton<ICoreDbContextFactory, CoreDbContextFactory>();

        return services;
    }

}
