using ttshang.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace ttshang.Permissions;

public class ttshangPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ttshangPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(ttshangPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ttshangResource>(name);
    }
}
