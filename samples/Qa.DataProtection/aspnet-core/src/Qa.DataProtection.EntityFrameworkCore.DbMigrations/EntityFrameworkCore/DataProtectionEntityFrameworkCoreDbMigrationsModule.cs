using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Qa.DataProtection.EntityFrameworkCore
{
    [DependsOn(
        typeof(DataProtectionEntityFrameworkCoreModule)
        )]
    public class DataProtectionEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DataProtectionMigrationsDbContext>();
        }
    }
}
