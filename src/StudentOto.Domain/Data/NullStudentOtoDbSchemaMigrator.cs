using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace StudentOto.Data;

/* This is used if database provider does't define
 * IStudentOtoDbSchemaMigrator implementation.
 */
public class NullStudentOtoDbSchemaMigrator : IStudentOtoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
