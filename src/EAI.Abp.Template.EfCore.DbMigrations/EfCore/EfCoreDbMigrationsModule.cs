using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace $safeprojectname$
{
    [DependsOn(
        typeof(EfCoreModule)
    )]
    public class EfCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MigrationsDbContext>();
        }
    }
}