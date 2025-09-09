using System.Threading.Tasks;

namespace StudentOto.Data;

public interface IStudentOtoDbSchemaMigrator
{
    Task MigrateAsync();
}
