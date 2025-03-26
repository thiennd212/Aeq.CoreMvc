using System;
using System.Collections.Generic;
using System.Text;
using Aeq.CoreMvc.Localization;
using Volo.Abp.Application.Services;

namespace Aeq.CoreMvc;

/* Inherit your application services from this class.
 */
public abstract class CoreMvcAppService : ApplicationService
{
    protected CoreMvcAppService()
    {
        LocalizationResource = typeof(CoreMvcResource);
    }
}
