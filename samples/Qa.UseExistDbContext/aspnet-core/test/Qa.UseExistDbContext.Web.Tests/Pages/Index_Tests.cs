using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Qa.UseExistDbContext.Pages
{
    public class Index_Tests : UseExistDbContextWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
