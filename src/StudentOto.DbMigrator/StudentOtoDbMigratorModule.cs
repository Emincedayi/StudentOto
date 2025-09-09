using StudentOto.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace StudentOto.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudentOtoEntityFrameworkCoreModule),
    typeof(StudentOtoApplicationContractsModule)
)]
public class StudentOtoDbMigratorModule : AbpModule
{
}
