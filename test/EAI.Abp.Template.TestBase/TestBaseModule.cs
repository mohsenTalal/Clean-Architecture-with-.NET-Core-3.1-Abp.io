using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using $ext_safeprojectname$.Domain;

using Volo.Abp.Autofac;


using Volo.Abp.Modularity;
using Volo.Abp.Threading;

namespace $safeprojectname$
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpTestBaseModule),
       // typeof(AbpAuthorizationModule),
        typeof(DomainModule)
        )]
    public class TestBaseModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //Configure<AbpBackgroundJobOptions>(options =>
            //{
            //    options.IsJobExecutionEnabled = false;
            //});

            //context.Services.AddAlwaysAllowAuthorization();
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            SeedTestData(context);
        }

        private static void SeedTestData(ApplicationInitializationContext context)
        {
            //AsyncHelper.RunSync(async () =>
            //{
            //    using (var scope = context.ServiceProvider.CreateScope())
            //    {
            //        await scope.ServiceProvider
            //            .GetRequiredService<IDataSeeder>()
            //            .SeedAsync();
            //    }
            //});
        }
    }
}
