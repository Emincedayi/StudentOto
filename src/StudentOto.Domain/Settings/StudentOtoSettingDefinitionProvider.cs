using Volo.Abp.Settings;

namespace StudentOto.Settings;

public class StudentOtoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StudentOtoSettings.MySetting1));
    }
}
