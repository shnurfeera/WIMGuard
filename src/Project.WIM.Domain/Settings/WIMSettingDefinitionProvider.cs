using Volo.Abp.Settings;

namespace Project.WIM.Settings
{
    public class WIMSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(WIMSettings.MySetting1));
        }
    }
}
