using System;
using System.Collections.Generic;
using System.Text;
using Project.WIM.Localization;
using Volo.Abp.Application.Services;

namespace Project.WIM
{
    /* Inherit your application services from this class.
     */
    public abstract class WIMAppService : ApplicationService
    {
        protected WIMAppService()
        {
            LocalizationResource = typeof(WIMResource);
        }
    }
}
