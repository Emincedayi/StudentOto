using Volo.Abp.Modularity;

namespace StudentOto;

[DependsOn(
    typeof(StudentOtoDomainModule),
    typeof(StudentOtoTestBaseModule)
)]
public class StudentOtoDomainTestModule : AbpModule
{

}
