using System.Threading.Tasks;

namespace Qa.UseExistDbContext.Data
{
    public interface IUseExistDbContextDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
