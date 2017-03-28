using CHXDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;

namespace CHXPostgreSqlLibrary
{
    public abstract class IPgDataConverter
    {
        public abstract IEnumerable<T> Convert<T>(CHXQuery query, dynamic data);
    }
}
