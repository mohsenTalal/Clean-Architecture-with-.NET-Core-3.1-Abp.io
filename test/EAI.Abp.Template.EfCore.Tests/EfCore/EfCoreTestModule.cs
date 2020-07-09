using Microsoft.Data.Sqlite;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity;
using $ext_safeprojectname$.TestBase;


namespace $safeprojectname$
{
    [DependsOn(
        typeof(TestBaseModule)
        )]
    public class EfCoreTestModule : AbpModule
    {
        private SqliteConnection _sqliteConnection;

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureInMemorySqlite(context.Services);
        }

        private void ConfigureInMemorySqlite(IServiceCollection services)
        {
            _sqliteConnection = CreateDatabaseAndGetConnection();

           // services.Configure<AbpDbContextOptions>(options =>
           // {
           //     options.Configure(context => { context.DbContextOptions.UseSqlite(_sqliteConnection); });
           // });
        }

        public override void OnApplicationShutdown(ApplicationShutdownContext context)
        {
            _sqliteConnection.Dispose();
        }

        private static SqliteConnection CreateDatabaseAndGetConnection()
        {
            var connection = new SqliteConnection("Data Source=:memory:");
            connection.Open();

           // var options = new DbContextOptionsBuilder<BillServicesMigrationsDbContext>()
             //   .UseSqlite(connection)
             //   .Options;

           // using (var context = new BillServicesMigrationsDbContext(options))
           // {
           //     context.GetService<IRelationalDatabaseCreator>().CreateTables();
           // }

            return connection;
        }
    }
}
