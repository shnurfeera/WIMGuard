using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Project.WIM.Localization;
using Project.WIM.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Project.WIM.Web.Menus
{
    public class WIMMenuContributor : IMenuContributor
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
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<WIMResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(WIMMenus.Home, l["Menu:Home"], "~/"));

            context.Menu.AddItem(
                new ApplicationMenuItem(
                    "WIM",
                    l["Menu:WIM"],
                    icon: "fa fa-book"
                    ).AddItem(
                    new ApplicationMenuItem(
                        "WIM.Wells",
                        l["Menu:Wells"],
                        url: "/Wells"
                        )
                    )                    
                );
        }
    }
}
