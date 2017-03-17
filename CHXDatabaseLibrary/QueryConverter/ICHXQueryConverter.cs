using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.QueryConverter
{
    public abstract class ICHXQueryConverter
    {
        public abstract QueryContainer Convert<T>(T data);
    }
}
