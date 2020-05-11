using Qa.UseExistDbContext.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Qa.UseExistDbContext.Permissions
{
    public class UseExistDbContextPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(UseExistDbContextPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(UseExistDbContextPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<UseExistDbContextResource>(name);
        }
    }
}
