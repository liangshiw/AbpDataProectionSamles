using Qa.UseExistDbContext.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Qa.UseExistDbContext.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(UseExistDbContextEntityFrameworkCoreDbMigrationsModule),
        typeof(UseExistDbContextApplicationContractsModule)
        )]
    public class UseExistDbContextDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
