using Volo.Abp.Settings;

namespace AbpSampleApp.AccessManagment.Settings;

public class AccessManagmentSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AccessManagmentSettings.MySetting1));
    }
}
