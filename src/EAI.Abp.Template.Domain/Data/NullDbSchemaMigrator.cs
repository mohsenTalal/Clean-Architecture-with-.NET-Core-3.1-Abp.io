using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace $safeprojectname$.Data
{
    /* This is used if database provider doesn't define
    * IAbpDemoDbSchemaMigrator implementation.
    */

    public class NullDbSchemaMigrator : IDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}