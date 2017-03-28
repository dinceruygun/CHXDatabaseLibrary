using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabase.IO
{
    [DebuggerDisplay("{ToString()}")]
    public class CHXDatabaseParameters : List<CHXDatabaseParameter>
    {
        public override string ToString()
        {
            return string.Join("; ", this.Select(a => a.ToString()).ToArray()) + ";";
        }

        public void Add(string name, string value)
        {
            this.Add(new CHXDatabaseParameter(name, value));
        }
    }
}
