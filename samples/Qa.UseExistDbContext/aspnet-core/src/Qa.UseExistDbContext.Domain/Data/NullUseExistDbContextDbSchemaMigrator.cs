using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Qa.UseExistDbContext.Data
{
    /* This is used if database provider does't define
     * IUseExistDbContextDbSchemaMigrator implementation.
     */
    public class NullUseExistDbContextDbSchemaMigrator : IUseExistDbContextDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}