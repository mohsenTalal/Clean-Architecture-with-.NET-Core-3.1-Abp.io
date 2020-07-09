using Volo.Abp.Modularity;
using $ext_safeprojectname$.Application.Contracts;

namespace $safeprojectname$
{
    [DependsOn(
        typeof(ApplicationContractsModule)
       
        )]
    public class HttpApiModule : AbpModule
    {

    }
}
