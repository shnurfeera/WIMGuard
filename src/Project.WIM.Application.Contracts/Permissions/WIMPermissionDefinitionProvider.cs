using Project.WIM.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Project.WIM.Permissions
{
    public class WIMPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(WIMPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(WIMPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<WIMResource>(name);
        }
    }
}
