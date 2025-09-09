using Volo.Abp.Modularity;

namespace StudentOto;

/* Inherit from this class for your domain layer tests. */
public abstract class StudentOtoDomainTestBase<TStartupModule> : StudentOtoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
