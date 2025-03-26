using Volo.Abp.Settings;

namespace Aeq.CoreMvc.Settings;

public class CoreMvcSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CoreMvcSettings.MySetting1));
    }
}
