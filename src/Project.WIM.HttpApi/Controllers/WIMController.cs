using Project.WIM.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Project.WIM.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class WIMController : AbpController
    {
        protected WIMController()
        {
            LocalizationResource = typeof(WIMResource);
        }
    }
}