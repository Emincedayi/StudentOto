using StudentOto.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace StudentOto.Permissions;

public class StudentOtoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StudentOtoPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(StudentOtoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StudentOtoResource>(name);
    }
}
