using System;
using System.Collections.Generic;
using System.Text;
using $ext_safeprojectname$.Domain;
using $ext_safeprojectname$.Application.Contracts;

using Volo.Abp.Modularity;

namespace $safeprojectname$
{
    [DependsOn(
         typeof(DomainModule), 
         typeof(ApplicationContractsModule)    
         )]
    public class ApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //Configure<AbpAutoMapperOptions>(options =>
            //{
            //    options.AddMaps<BillServicesApplicationModule>();
            //});
        }
    }
}
