using Dapper;
using DapperAtFirstGlance.Application.Common.Interfaces;
using DapperAtFirstGlance.Domain.Entities;
using System.Data;
using System.Threading.Tasks;

namespace DapperAtFirstGlance.Application.Core.Records.Commands
{
    public class AddRecordCommand
    {
        private IApplicationDbContext _context;

        public AddRecordCommand(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Insert(Record record)
        {
            using IDbConnection connection = _context.GetConnection();

            var id = await connection.QueryFirstOrDefaultAsync<int>(
                @"INSERT INTO Record (Name, CatalogueNumber, LabelId, GenreId)
                OUTPUT Record.RecordId
                VALUES (@name, @catalogueNo, @labelId, @genreId)",
                new
                {
                    name = record.Name,
                    catalogueNo = record.CatalogueNumber,
                    labelId = record.LabelId,
                    genreId = record.GenreId
                });

            return id;
        }
    }
}
