using System;
using System.Collections.Generic;
using System.Text;
using $safeprojectname$;
using $ext_safeprojectname$.Domain.Shared;
using Volo.Abp.AuditLogging;
using Volo.Abp.Modularity;

namespace $safeprojectname$
{
    [DependsOn( typeof(DomainSharedModule),
	   typeof(AbpAuditLoggingDomainModule)
	)]
    public class DomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            
        }
    }
}
