using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.QueryConverter
{
    public class QueryContainer
    {
        public string Server { get; set; }
        public string Schema { get; set; }
        public QueryCollection Query { get; set; }

    }


    public class QueryTable : IQueryTable { }

    public abstract class IQueryTable
    {
        public string type { get; set; }
        public bool addgeometry { get; set; }
        public List<string> field { get; set; }
    }


    public class QueryCollection : List<QueryTable>
    {

    }
}
