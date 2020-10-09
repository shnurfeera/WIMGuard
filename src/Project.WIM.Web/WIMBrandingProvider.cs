using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Project.WIM.Web
{
    [Dependency(ReplaceServices = true)]
    public class WIMBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "WIM";
    }
}
