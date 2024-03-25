using FirstDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FirstDemo.Permissions;

public class FirstDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FirstDemoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(FirstDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FirstDemoResource>(name);
    }
}
