using Dapper;
using DapperAtFirstGlance.Application.Common.Interfaces;
using DapperAtFirstGlance.Domain.Entities;
using System.Data;
using System.Threading.Tasks;

namespace DapperAtFirstGlance.Application.Core.Records.Queries
{
    public class GetRecordQuery
    {
        private IApplicationDbContext _context;

        public GetRecordQuery(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Record> GetForName(string nameOfRecord)
        {
            using IDbConnection connection = _context.GetConnection();

            var record = await connection.QueryFirstOrDefaultAsync<Record>(
                "SELECT * FROM Record WHERE Name = @NameToFind",
                new { NameToFind = nameOfRecord }
                );

            return record;
        }
    }
}
