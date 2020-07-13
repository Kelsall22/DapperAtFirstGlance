using System.Data;

namespace DapperAtFirstGlance.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        IDbConnection GetConnection();
    }
}
