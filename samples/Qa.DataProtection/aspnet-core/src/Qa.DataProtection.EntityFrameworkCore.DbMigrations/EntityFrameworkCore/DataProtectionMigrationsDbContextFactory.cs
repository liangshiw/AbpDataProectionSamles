using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Qa.DataProtection.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class DataProtectionMigrationsDbContextFactory : IDesignTimeDbContextFactory<DataProtectionMigrationsDbContext>
    {
        public DataProtectionMigrationsDbContext CreateDbContext(string[] args)
        {
            DataProtectionEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<DataProtectionMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new DataProtectionMigrationsDbContext(builder.Options);
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
