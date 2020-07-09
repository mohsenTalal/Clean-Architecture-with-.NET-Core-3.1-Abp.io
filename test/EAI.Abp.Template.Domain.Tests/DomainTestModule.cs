using System;
using System.Collections.Generic;
using System.Text;
using $ext_safeprojectname$.EfCore.Tests;
using Volo.Abp.Modularity;

namespace $safeprojectname$
{
    [DependsOn(
       typeof(EfCoreTestModule)
       )]
    public class DomainTestModule : AbpModule
    {

    }
}
