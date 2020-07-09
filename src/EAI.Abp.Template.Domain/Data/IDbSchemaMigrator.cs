using System.Threading.Tasks;

namespace $safeprojectname$.Data
{
    public interface IDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}