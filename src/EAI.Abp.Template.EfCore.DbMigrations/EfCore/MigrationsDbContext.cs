using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace $safeprojectname$
{
    /* This DbContext is only used for database migrations.
    * It is not used on runtime. See BillServicesDbContext for the runtime DbContext.
    * It is a unified model that includes configuration for
    * all used modules and your application.
    */

    public class MigrationsDbContext : AbpDbContext<MigrationsDbContext>
    {
        public MigrationsDbContext(DbContextOptions<MigrationsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            /* Configure customizations for entities from the modules included  */

            //builder.Entity<IdentityUser>(b =>
            //{
            //    b.ConfigureCustomUserProperties();
            //});

            /* Configure your own tables/entities inside the ConfigureBillServices method */

            builder.ConfigureAuditLogging();

            builder.ConfigureBillServices();
        }
    }
}