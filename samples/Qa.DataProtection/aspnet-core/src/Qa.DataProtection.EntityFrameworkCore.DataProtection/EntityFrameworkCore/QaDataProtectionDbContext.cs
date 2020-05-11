using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Qa.DataProtection.EntityFrameworkCore
{
    [ConnectionStringName("DataProtection")]
    public class QaDataProtectionDbContext : AbpDbContext<QaDataProtectionDbContext>,IDataProtectionKeyContext
    {
        public QaDataProtectionDbContext(DbContextOptions<QaDataProtectionDbContext> options) : base(options)
        {
        }

        public DbSet<DataProtectionKey> DataProtectionKeys { get; set; }
    }
}
