using Aeq.CoreMvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Aeq.CoreMvc.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class CoreMvcPageModel : AbpPageModel
{
    protected CoreMvcPageModel()
    {
        LocalizationResourceType = typeof(CoreMvcResource);
    }
}
