using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXIndex.SearchDirectory
{
    public abstract class IDirectory
    {
        public abstract Lucene.Net.Store.Directory Open();
    }
}
