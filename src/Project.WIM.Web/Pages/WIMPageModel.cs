using Project.WIM.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Project.WIM.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class WIMPageModel : AbpPageModel
    {
        protected WIMPageModel()
        {
            LocalizationResourceType = typeof(WIMResource);
        }
    }
}