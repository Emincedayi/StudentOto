using StudentOto.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace StudentOto.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudentOtoController : AbpControllerBase
{
    protected StudentOtoController()
    {
        LocalizationResource = typeof(StudentOtoResource);
    }
}
