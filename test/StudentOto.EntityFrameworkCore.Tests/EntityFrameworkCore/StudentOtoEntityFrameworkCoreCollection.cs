using Xunit;

namespace StudentOto.EntityFrameworkCore;

[CollectionDefinition(StudentOtoTestConsts.CollectionDefinitionName)]
public class StudentOtoEntityFrameworkCoreCollection : ICollectionFixture<StudentOtoEntityFrameworkCoreFixture>
{

}
