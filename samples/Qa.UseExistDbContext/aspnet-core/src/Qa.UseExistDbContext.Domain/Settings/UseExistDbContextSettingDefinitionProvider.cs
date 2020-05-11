using Volo.Abp.Settings;

namespace Qa.UseExistDbContext.Settings
{
    public class UseExistDbContextSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(UseExistDbContextSettings.MySetting1));
        }
    }
}
