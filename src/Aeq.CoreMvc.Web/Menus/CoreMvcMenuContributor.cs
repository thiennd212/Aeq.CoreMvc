using System.Threading.Tasks;
using Aeq.CoreMvc.Permissions;
using Aeq.CoreMvc.Localization;
using Aeq.CoreMvc.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Aeq.CoreMvc.Web.Menus;

public class CoreMvcMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<CoreMvcResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                CoreMvcMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        //return Task.CompletedTask;
        if (await context.IsGrantedAsync(CoreMvcPermissions.Book.Default))
        {
            context.Menu.GetAdministration().AddItem(
                new ApplicationMenuItem(CoreMvcMenus.Book, l["Menu:Book"], "/Books/Book")
            );
        }
        if (await context.IsGrantedAsync(CoreMvcPermissions.Author.Default))
        {
            context.Menu.GetAdministration().AddItem(
                new ApplicationMenuItem(CoreMvcMenus.Author, l["Menu:Author"], "/Books/Author")
            );
        }
    }
}
