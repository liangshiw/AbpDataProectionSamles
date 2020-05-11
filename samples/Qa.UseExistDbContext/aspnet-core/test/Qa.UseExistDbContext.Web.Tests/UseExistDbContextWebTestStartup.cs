using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Qa.UseExistDbContext
{
    public class UseExistDbContextWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<UseExistDbContextWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}