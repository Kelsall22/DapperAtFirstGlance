using System.Data;
using System.Data.SqlClient;

namespace DapperAtFirstGlance.Infrastructure.Persistance
{
    public class ApplicationDbContext
    {
        public IDbConnection GetConnection()
        {
            return new SqlConnection("ConnectionString");
        }
    }
}
