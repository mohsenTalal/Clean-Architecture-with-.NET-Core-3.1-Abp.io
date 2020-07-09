using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace $safeprojectname$
{
    public class DomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            //Configure<AbpVirtualFileSystemOptions>(options =>
            //{
            //    options.FileSets.AddEmbedded<BillServicesDomainSharedModule>("$safeprojectname$");
            //});

            //Configure<AbpLocalizationOptions>(options =>
            //{
            //    options.Resources
            //        .Add<BillServicesResource>("en")
            //        .AddBaseTypes(typeof(AbpValidationResource))
            //        .AddVirtualJson("/Localization/BillServices");
            //});
        }
    }
}
