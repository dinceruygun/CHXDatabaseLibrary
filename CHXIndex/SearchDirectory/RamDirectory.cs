using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXIndex.SearchDirectory
{
    public class RamDirectory : IDirectory
    {
        public override Lucene.Net.Store.Directory Open()
        {
            var luceneDirectory = new Lucene.Net.Store.RAMDirectory();

            return luceneDirectory;
        }
    }
}
