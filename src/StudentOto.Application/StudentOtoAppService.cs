using StudentOto.Localization;
using Volo.Abp.Application.Services;

namespace StudentOto;

/* Inherit your application services from this class.
 */
public abstract class StudentOtoAppService : ApplicationService
{
    protected StudentOtoAppService()
    {
        LocalizationResource = typeof(StudentOtoResource);
    }
}
