using Qa.DataProtection.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Qa.DataProtection.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DataProtectionEntityFrameworkCoreDbMigrationsModule),
        typeof(DataProtectionApplicationContractsModule)
        )]
    public class DataProtectionDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
