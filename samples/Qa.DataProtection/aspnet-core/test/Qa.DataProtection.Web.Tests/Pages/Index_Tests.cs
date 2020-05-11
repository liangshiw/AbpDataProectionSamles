using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Qa.DataProtection.Pages
{
    public class Index_Tests : DataProtectionWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
