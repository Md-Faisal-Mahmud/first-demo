using Volo.Abp.Settings;

namespace FirstDemo.Settings;

public class FirstDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FirstDemoSettings.MySetting1));
    }
}
