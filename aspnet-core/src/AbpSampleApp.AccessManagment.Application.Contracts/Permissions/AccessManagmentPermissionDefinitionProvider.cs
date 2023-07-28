using AbpSampleApp.AccessManagment.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpSampleApp.AccessManagment.Permissions;

public class AccessManagmentPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AccessManagmentPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AccessManagmentPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AccessManagmentResource>(name);
    }
}
