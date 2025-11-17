using System.Threading.Tasks;
using ttshang.Localization;
using ttshang.Permissions;
using ttshang.MultiTenancy;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.UI.Navigation;
//using Volo.Abp.SettingManagement.Blazor.Menus;
//using Volo.Abp.TenantManagement.Blazor.Navigation;
//using Volo.Abp.Identity.Blazor;
using AntDesign;
using Lsw.Abp.TenantManagement.Blazor.AntDesignUI;
using Lsw.Abp.IdentityManagement.Blazor.AntDesignUI;
using Lsw.Abp.SettingManagement.Blazor.AntDesignUI;

namespace ttshang.Blazor.Menus;

public class ttshangMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<ttshangResource>();
        
        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                ttshangMenus.Home,
                l["Menu:Home"],
                "/",
                icon: IconType.Outline.Home,
                order: 1
            )
        );

        //Administration
        var administration = context.Menu.GetAdministration();
        administration.Order = 6;
    
        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        return Task.CompletedTask;
    }
}
