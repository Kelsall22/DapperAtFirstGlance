using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperAtFirstGlance.Domain.Entities
{
    public class Record
    {
        public int RecordId { get; set; }
        public string CatalogueNumber { get; set; }
        public string Name { get; set; }
        public int LabelId { get; set; }
        public int GenreId { get; set; }
    }
}
