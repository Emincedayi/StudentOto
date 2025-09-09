using StudentOto.Localization;
using Volo.Abp.AspNetCore.Components;

namespace StudentOto.Blazor;

public abstract class StudentOtoComponentBase : AbpComponentBase
{
    protected StudentOtoComponentBase()
    {
        LocalizationResource = typeof(StudentOtoResource);
    }
}
