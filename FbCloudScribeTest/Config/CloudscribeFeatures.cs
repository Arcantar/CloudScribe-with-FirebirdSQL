using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CloudscribeFeatures
    {

        public static IServiceCollection SetupDataStorage(
            this IServiceCollection services,
            IConfiguration config,
            IWebHostEnvironment env
            )
        {
            var connectionString = config.GetConnectionString("EntityFrameworkConnection");


            services.AddCloudscribeCoreEFStorageFbSql(connectionString);


            services.AddCloudscribeLoggingEFStorageFbSQL(connectionString);

            services.AddCloudscribeSimpleContentEFStorageFbSQL(connectionString);



            services.AddDynamicPolicyEFStorageFbSql(connectionString);








            return services;
        }

        public static IServiceCollection SetupCloudscribeFeatures(
            this IServiceCollection services,
            IConfiguration config
            )
        {




            services.AddScoped<cloudscribe.Web.Navigation.INavigationNodePermissionResolver, cloudscribe.Web.Navigation.NavigationNodePermissionResolver>();
            services.AddScoped<cloudscribe.Web.Navigation.INavigationNodePermissionResolver, cloudscribe.SimpleContent.Web.Services.PagesNavigationNodePermissionResolver>();
            services.AddCloudscribeCoreMvc(config);
            services.AddCloudscribeCoreIntegrationForSimpleContent(config);
            services.AddSimpleContentMvc(config);
            services.AddContentTemplatesForSimpleContent(config);

            services.AddMetaWeblogForSimpleContent(config.GetSection("MetaWeblogApiOptions"));
            services.AddSimpleContentRssSyndiction();
            services.AddCloudscribeSimpleContactFormCoreIntegration(config);
            services.AddCloudscribeSimpleContactForm(config);

            services.AddCloudscribeLogging(config);





            services.AddCloudscribeDynamicPolicyIntegration(config);
            services.AddDynamicAuthorizationMvc(config);




            return services;
        }

    }
}
