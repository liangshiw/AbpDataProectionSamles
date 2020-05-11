using Qa.DataProtection.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Qa.DataProtection.Permissions
{
    public class DataProtectionPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DataProtectionPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(DataProtectionPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DataProtectionResource>(name);
        }
    }
}
