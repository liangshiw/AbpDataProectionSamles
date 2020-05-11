using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Qa.UseExistDbContext.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class UseExistDbContextMigrationsDbContextFactory : IDesignTimeDbContextFactory<UseExistDbContextMigrationsDbContext>
    {
        public UseExistDbContextMigrationsDbContext CreateDbContext(string[] args)
        {
            UseExistDbContextEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<UseExistDbContextMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new UseExistDbContextMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
