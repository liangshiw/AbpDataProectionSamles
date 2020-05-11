using System.Threading.Tasks;

namespace Qa.DataProtection.Data
{
    public interface IDataProtectionDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
