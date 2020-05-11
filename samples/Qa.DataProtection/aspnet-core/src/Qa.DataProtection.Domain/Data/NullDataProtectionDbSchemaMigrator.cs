using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Qa.DataProtection.Data
{
    /* This is used if database provider does't define
     * IDataProtectionDbSchemaMigrator implementation.
     */
    public class NullDataProtectionDbSchemaMigrator : IDataProtectionDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}