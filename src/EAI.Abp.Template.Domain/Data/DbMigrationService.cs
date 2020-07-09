using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace $safeprojectname$.Data
{
    public class DbMigrationService : ITransientDependency
    {
        private readonly IDataSeeder _dataSeeder;
        private readonly IDbSchemaMigrator _dbSchemaMigrator;

        public DbMigrationService(
            IDataSeeder dataSeeder,
            IDbSchemaMigrator dbSchemaMigrator)
        {
            _dataSeeder = dataSeeder;
            _dbSchemaMigrator = dbSchemaMigrator;

            Logger = NullLogger<DbMigrationService>.Instance;
        }

        public ILogger<DbMigrationService> Logger { get; set; }

        public async Task MigrateAsync()
        {
            Logger.LogInformation("Started database migrations...");

            Logger.LogInformation("Migrating database schema...");
            await _dbSchemaMigrator.MigrateAsync();

            Logger.LogInformation("Executing database seed...");
            await _dataSeeder.SeedAsync();

            Logger.LogInformation("Successfully completed database migrations.");
        }
    }
}