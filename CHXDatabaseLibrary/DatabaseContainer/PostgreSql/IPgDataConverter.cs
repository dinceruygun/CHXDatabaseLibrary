using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.DatabaseContainer.PostgreSql
{
    public abstract class IPgDataConverter
    {
        public abstract IEnumerable<T> Convert<T>(CHXQuery query, dynamic data);
    }
}
