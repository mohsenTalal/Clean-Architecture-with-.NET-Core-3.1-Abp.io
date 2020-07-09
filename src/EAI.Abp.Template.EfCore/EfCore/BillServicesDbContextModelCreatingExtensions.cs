using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;

namespace $safeprojectname$
{
    public static class BillServicesDbContextModelCreatingExtensions
    {
        public static void ConfigureBillServices(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BillServicesConsts.DbTablePrefix + "YourEntities", BillServicesConsts.DbSchema);

            //    //...
            //});
        }

    }
}
