using Microsoft.Extensions.Localization;
using StudentOto.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace StudentOto.Blazor;

[Dependency(ReplaceServices = true)]
public class StudentOtoBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<StudentOtoResource> _localizer;

    public StudentOtoBrandingProvider(IStringLocalizer<StudentOtoResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
