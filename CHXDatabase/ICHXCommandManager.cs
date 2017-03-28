using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabase.IO
{
    public abstract class ICHXCommandManager
    {
        public abstract ICHXDatabaseCommand Commands { get; }
    }
}
