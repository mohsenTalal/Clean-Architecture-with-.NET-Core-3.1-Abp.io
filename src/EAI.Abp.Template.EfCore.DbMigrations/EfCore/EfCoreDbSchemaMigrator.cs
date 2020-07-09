using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using $ext_projectname$.Domain.Data;
using Volo.Abp.DependencyInjection;

namespace $safeprojectname$
{
    [Dependency(ReplaceServices = true)]
    public class EfCoreDbSchemaMigrator
         : IDbSchemaMigrator, ITransientDependency
    {
        private readonly MigrationsDbContext _dbContext;

        public EfCoreDbSchemaMigrator(MigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}