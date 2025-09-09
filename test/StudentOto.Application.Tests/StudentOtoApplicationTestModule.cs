using Volo.Abp.Modularity;

namespace StudentOto;

[DependsOn(
    typeof(StudentOtoApplicationModule),
    typeof(StudentOtoDomainTestModule)
)]
public class StudentOtoApplicationTestModule : AbpModule
{

}
