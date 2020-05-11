using Volo.Abp.Settings;

namespace Qa.DataProtection.Settings
{
    public class DataProtectionSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DataProtectionSettings.MySetting1));
        }
    }
}
