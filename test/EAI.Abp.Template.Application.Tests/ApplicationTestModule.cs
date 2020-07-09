using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;
using $ext_safeprojectname$.Domain.Tests;
namespace $safeprojectname$
{
    [DependsOn(
        typeof(ApplicationModule),
        typeof(DomainTestModule)
        )]
    public class ApplicationTestModule : AbpModule
    {

    }
}