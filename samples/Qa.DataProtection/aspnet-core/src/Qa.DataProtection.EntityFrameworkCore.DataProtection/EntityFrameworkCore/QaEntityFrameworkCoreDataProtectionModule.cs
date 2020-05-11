using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Modularity;

namespace Qa.DataProtection.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpEntityFrameworkCoreSqlServerModule)
    )]
    public class QaEntityFrameworkCoreDataProtectionModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<QaDataProtectionDbContext>();

            Configure<AbpDbContextOptions>(options =>
            {
                /* The main point to change your DBMS.
                 * See also qaMigrationsDbContextFactory for EF Core tooling. */
                options.UseSqlServer();
            });

            context.Services.AddDataProtection()
            .PersistKeysToDbContext<QaDataProtectionDbContext>();
        }
    }
}
