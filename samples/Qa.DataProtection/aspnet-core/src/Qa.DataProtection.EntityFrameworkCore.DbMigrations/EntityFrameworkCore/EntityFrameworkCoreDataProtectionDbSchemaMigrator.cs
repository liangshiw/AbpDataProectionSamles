using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Qa.DataProtection.Data;
using Volo.Abp.DependencyInjection;

namespace Qa.DataProtection.EntityFrameworkCore
{
    public class EntityFrameworkCoreDataProtectionDbSchemaMigrator
        : IDataProtectionDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreDataProtectionDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the DataProtectionMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<DataProtectionMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}