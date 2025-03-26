using Aeq.CoreMvc.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Aeq.CoreMvc.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CoreMvcController : AbpControllerBase
{
    protected CoreMvcController()
    {
        LocalizationResource = typeof(CoreMvcResource);
    }
}
