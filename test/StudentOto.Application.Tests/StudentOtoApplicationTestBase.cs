using Volo.Abp.Modularity;

namespace StudentOto;

public abstract class StudentOtoApplicationTestBase<TStartupModule> : StudentOtoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
