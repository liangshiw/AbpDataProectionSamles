using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Qa.UseExistDbContext.EntityFrameworkCore
{
    [DependsOn(
        typeof(UseExistDbContextEntityFrameworkCoreModule)
        )]
    public class UseExistDbContextEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<UseExistDbContextMigrationsDbContext>();
        }
    }
}
