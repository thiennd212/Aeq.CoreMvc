using Microsoft.Extensions.Localization;
using Aeq.CoreMvc.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Aeq.CoreMvc.Web;

[Dependency(ReplaceServices = true)]
public class CoreMvcBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<CoreMvcResource> _localizer;

    public CoreMvcBrandingProvider(IStringLocalizer<CoreMvcResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
