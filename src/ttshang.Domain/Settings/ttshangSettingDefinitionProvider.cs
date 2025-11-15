using Volo.Abp.Settings;

namespace ttshang.Settings;

public class ttshangSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ttshangSettings.MySetting1));
    }
}
