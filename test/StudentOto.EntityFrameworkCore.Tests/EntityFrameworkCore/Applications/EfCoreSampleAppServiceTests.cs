using StudentOto.Samples;
using Xunit;

namespace StudentOto.EntityFrameworkCore.Applications;

[Collection(StudentOtoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StudentOtoEntityFrameworkCoreTestModule>
{

}
