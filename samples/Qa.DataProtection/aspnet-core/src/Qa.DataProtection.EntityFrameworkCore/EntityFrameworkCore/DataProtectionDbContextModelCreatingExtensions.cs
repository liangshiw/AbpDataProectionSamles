using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Qa.DataProtection.EntityFrameworkCore
{
    public static class DataProtectionDbContextModelCreatingExtensions
    {
        public static void ConfigureDataProtection(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(DataProtectionConsts.DbTablePrefix + "YourEntities", DataProtectionConsts.DbSchema);

            //    //...
            //});
        }
    }
}