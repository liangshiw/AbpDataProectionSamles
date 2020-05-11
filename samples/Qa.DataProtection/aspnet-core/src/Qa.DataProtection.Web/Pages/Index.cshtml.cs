using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Logging;

namespace Qa.DataProtection.Web.Pages
{
    public class IndexModel : DataProtectionPageModel
    {
        private IDataProtector _protector;

        public IndexModel(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("Contoso.MyClass.v1");
        }

        public void OnGet()
        {
            var input = "hello world";

            // protect the payload
            string protectedPayload = _protector.Protect(input);
            Logger.LogInformation($"Protect returned: {protectedPayload}");

            // unprotect the payload
            string unprotectedPayload = _protector.Unprotect(protectedPayload);
            Logger.LogInformation($"Unprotect returned: {unprotectedPayload}");
        }
    }
}
