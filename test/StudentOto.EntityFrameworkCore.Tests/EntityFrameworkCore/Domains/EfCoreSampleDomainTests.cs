using StudentOto.Samples;
using Xunit;

namespace StudentOto.EntityFrameworkCore.Domains;

[Collection(StudentOtoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StudentOtoEntityFrameworkCoreTestModule>
{

}
