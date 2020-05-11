using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Qa.UseExistDbContext.Data;
using Volo.Abp.DependencyInjection;

namespace Qa.UseExistDbContext.EntityFrameworkCore
{
    public class EntityFrameworkCoreUseExistDbContextDbSchemaMigrator
        : IUseExistDbContextDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreUseExistDbContextDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the UseExistDbContextMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<UseExistDbContextMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}