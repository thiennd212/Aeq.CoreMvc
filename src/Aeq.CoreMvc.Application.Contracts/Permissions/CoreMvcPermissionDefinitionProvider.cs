using Aeq.CoreMvc.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Aeq.CoreMvc.Permissions;

public class CoreMvcPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CoreMvcPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CoreMvcPermissions.MyPermission1, L("Permission:MyPermission1"));

        var bookPermission = myGroup.AddPermission(CoreMvcPermissions.Book.Default, L("Permission:Book"));
        bookPermission.AddChild(CoreMvcPermissions.Book.Create, L("Permission:Create"));
        bookPermission.AddChild(CoreMvcPermissions.Book.Update, L("Permission:Update"));
        bookPermission.AddChild(CoreMvcPermissions.Book.Delete, L("Permission:Delete"));

        var authorPermission = myGroup.AddPermission(CoreMvcPermissions.Author.Default, L("Permission:Author"));
        authorPermission.AddChild(CoreMvcPermissions.Author.Create, L("Permission:Create"));
        authorPermission.AddChild(CoreMvcPermissions.Author.Update, L("Permission:Update"));
        authorPermission.AddChild(CoreMvcPermissions.Author.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CoreMvcResource>(name);
    }
}
