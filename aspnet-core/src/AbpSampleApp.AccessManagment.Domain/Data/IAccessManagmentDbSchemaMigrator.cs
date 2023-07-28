using System.Threading.Tasks;

namespace AbpSampleApp.AccessManagment.Data;

public interface IAccessManagmentDbSchemaMigrator
{
    Task MigrateAsync();
}
