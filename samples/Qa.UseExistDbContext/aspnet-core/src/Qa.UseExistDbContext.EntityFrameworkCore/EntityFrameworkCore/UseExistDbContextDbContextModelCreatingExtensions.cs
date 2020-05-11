using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Qa.UseExistDbContext.EntityFrameworkCore
{
    public static class UseExistDbContextDbContextModelCreatingExtensions
    {
        public static void ConfigureUseExistDbContext(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(UseExistDbContextConsts.DbTablePrefix + "YourEntities", UseExistDbContextConsts.DbSchema);

            //    //...
            //});

            builder.Entity<DataProtectionKey>(b=>
            {
                b.ToTable("DataProtectionKeys");
            });
        }
    }
}