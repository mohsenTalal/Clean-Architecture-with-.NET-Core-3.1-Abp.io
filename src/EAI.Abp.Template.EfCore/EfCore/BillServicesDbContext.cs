using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace $safeprojectname$
{
    [ConnectionStringName("Default")]
    public class BillServicesDbContext : AbpDbContext<BillServicesDbContext>
    {
      

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside BillServicesDbContextModelCreatingExtensions.ConfigureBillServices
         */

        public BillServicesDbContext(DbContextOptions<BillServicesDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

           

            /* Configure your own tables/entities inside the ConfigureBillServices method */

            builder.ConfigureBillServices();
        }
    }
}
